using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL;
using System.Drawing;
using System.Drawing.Imaging;

#pragma warning disable CS0618

namespace TomogrammVisualizer
{
    class View
    {
        int WIDTH_IN = 1500;
        int MIN_IN = -1000;
        Bitmap textureImage;
        int VBOtexture;
        public int clamp(int value, int min, int max) 
        {
            if (value < min)
                return min;
            if (value > max)
                return max;
            return value;
        }

        public void SetMin(ref int _min) { MIN_IN = _min; }
        public void SetWidth(ref int _width) { WIDTH_IN = _width; }

        public void SetupView(int width, int height) // Настройка камеры
        {
            GL.ShadeModel(ShadingModel.Smooth);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(0, Bin.X, 0, Bin.Y, -1, 1);
            //GL.Ortho(0, Bin.Y, 0, Bin.Z, -1, 1);
            GL.Viewport(0, 0, width, height);
        }

        Color TransferFunction(short value)// Перевод значения плотностей томограммы в цвет.
        {
            int newVal = clamp((value - MIN_IN) * 255 / WIDTH_IN, 0, 255);
            return Color.FromArgb(255, newVal, newVal, newVal);

            #region 
            /*int newVal = clamp((value - MIN_IN) * 255 / WIDTH_IN, 0, 255);
            if ((value >= -1000) && (value < -700)) // от легких до воздуха
            {
                return Color.DodgerBlue;
            } else if ((value >= -700) && (value < -400)) // от легких до жира
            {
                return Color.CornflowerBlue;
            }
            else if ((value >= -180) && (value < -30)) // от жира до молочной железы
            {
                return Color.CadetBlue;
            }
            else if ((value >= -30) && (value < 0)) // от молочной железы до воды
            {
                return Color.Blue; 
            }
            else if ((value >= 0) && (value < 30)) // от воды до мозга
            {
                return Color.DarkSeaGreen;
            }
            else if ((value >= 30) && (value < 70)) // от воды, почек, желудочков и до печени
            {
                return Color.ForestGreen;
            }
            else if ((value >= 30) && (value < 80)) // кровь
            {
                return Color.Red;
            }
            else if ((value >= 80) && (value < 1000)) // кости
            {
                return Color.White;
            } else return Color.FromArgb(255, newVal, newVal, newVal);*/
            #endregion
        }

        public void DrawQuads(int layerNumber) // отрисовка четырехугольниками
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Begin(BeginMode.Quads);
            for (int x_coord = 0; x_coord < Bin.X - 1; x_coord++)
                for (int y_coord = 0; y_coord < Bin.Y - 1; y_coord++)
                //for (int y_coord = 0; y_coord < Bin.Z - 1; y_coord++)
                {
                    short value;
                    //1 вершина
                    value = Bin.array[x_coord + y_coord * Bin.X + layerNumber * Bin.X * Bin.Y];
                    //value = Bin.array[x_coord + layerNumber * Bin.X + y_coord * Bin.X * Bin.Y];
                    GL.Color3(TransferFunction(value));
                    GL.Vertex2(x_coord, y_coord);
                    ////2 вершина
                    value = Bin.array[x_coord + (y_coord + 1) * Bin.X + layerNumber * Bin.X * Bin.Y];
                    //value = Bin.array[x_coord + layerNumber * Bin.X + (y_coord + 1) * Bin.X * Bin.Y];

                    GL.Color3(TransferFunction(value));
                    GL.Vertex2(x_coord, y_coord + 1);
                    ////3 вершина
                    value = Bin.array[x_coord + 1 + (y_coord + 1) * Bin.X + layerNumber * Bin.X * Bin.Y];
                    //value = Bin.array[x_coord + 1 + layerNumber * Bin.X + (y_coord + 1) * Bin.X * Bin.Y];

                    GL.Color3(TransferFunction(value));
                    GL.Vertex2(x_coord + 1, y_coord + 1);
                    ////4 вершина
                    value = Bin.array[x_coord + 1 + y_coord * Bin.X + layerNumber * Bin.X * Bin.Y];
                    //value = Bin.array[x_coord + 1 + layerNumber * Bin.X + y_coord * Bin.X * Bin.Y];

                    GL.Color3(TransferFunction(value));
                    GL.Vertex2(x_coord + 1, y_coord);
                }
            GL.End(); // синхронизация
        }

        public void Load2DTexture()
        {
            GL.BindTexture(TextureTarget.Texture2D, VBOtexture); // Связка текстуру, делает ее активной, а также указывает ее тип

            BitmapData data = textureImage.LockBits(
                new System.Drawing.Rectangle(0, 0, textureImage.Width, textureImage.Height),
                System.Drawing.Imaging.ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba, // Загрузка текстуры в память видеокарты.
                data.Width, data.Height, 0, OpenTK.Graphics.OpenGL.PixelFormat.Bgra,
                PixelType.UnsignedByte, data.Scan0);

            textureImage.UnlockBits(data);

            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter,
                (int)TextureMinFilter.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter,
                (int)TextureMagFilter.Linear);

            ErrorCode Er = GL.GetError();
            string str = Er.ToString();
        }

        public void generateTextureImage(int layerNumber) //Генерация изображения из томограммы при помощи созданной Transfer Function
        {
            textureImage = new Bitmap(Bin.X, Bin.Y);
            for (int i = 0; i < Bin.X; ++i)
                for (int j = 0; j < Bin.Y; ++j)
                {
                    int pixelNumber = i + j * Bin.X + layerNumber * Bin.X * Bin.Y;
                    textureImage.SetPixel(i, j, TransferFunction(Bin.array[pixelNumber]));
                }
        }

        public void DrawTexture() // ВКЛ 2d-текстурирование, Выбор текстуры и рисовать один прямоугольник с наложенной текстурой
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Enable(EnableCap.Texture2D);
            GL.BindTexture(TextureTarget.Texture2D, VBOtexture);
            GL.Begin(BeginMode.Quads);

            GL.Color3(Color.White);
            GL.TexCoord2(0f, 0f);
            GL.Vertex2(0, 0);
            GL.TexCoord2(0f, 1f);
            GL.Vertex2(0, Bin.Y);
            GL.TexCoord2(1f, 1f);
            GL.Vertex2(Bin.X, Bin.Y);
            GL.TexCoord2(1f, 0f);
            GL.Vertex2(Bin.X, 0);
            GL.End();

            GL.Disable(EnableCap.Texture2D);
        }

        public void DrawQuadStrip(int layerNumber)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            short value;
            int y_coord = 0;
            for (int x_coord = 0; x_coord < Bin.X - 1; x_coord++)
            {
                GL.Begin(BeginMode.QuadStrip);
                value = Bin.array[x_coord + y_coord * Bin.X + layerNumber * Bin.X * Bin.Y];
                GL.Color3(TransferFunction(value));
                GL.Vertex2(x_coord, y_coord);
                value = Bin.array[x_coord + (y_coord + 1) * Bin.X + layerNumber * Bin.X * Bin.Y];
                GL.Color3(TransferFunction(value));
                GL.Vertex2(x_coord, y_coord + 1);
                value = Bin.array[x_coord + 1 + (y_coord + 1) * Bin.X + layerNumber * Bin.X * Bin.Y];
                GL.Color3(TransferFunction(value));
                GL.Vertex2(x_coord + 1, y_coord + 1);
                value = Bin.array[x_coord + 1 + y_coord * Bin.X + layerNumber * Bin.X * Bin.Y];
                GL.Color3(TransferFunction(value));
                GL.Vertex2(x_coord + 1, y_coord);
                for (y_coord = 0; y_coord < Bin.Y; y_coord++)
                {
                    value = Bin.array[x_coord + y_coord * Bin.X + layerNumber * Bin.X * Bin.Y];
                    GL.Color3(TransferFunction(value));
                    GL.Vertex2(x_coord, y_coord);
                    value = Bin.array[x_coord + 1 + y_coord * Bin.X + layerNumber * Bin.X * Bin.Y];
                    GL.Color3(TransferFunction(value));
                    GL.Vertex2(x_coord + 1, y_coord);
                }
                GL.End();
            }
        }
    }
}
