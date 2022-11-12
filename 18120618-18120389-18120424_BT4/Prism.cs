using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using SharpGL;
using SharpGL.SceneGraph;

namespace Lab04
{
    class Prism : Object
    {
        private double Rbottom;
        private double alpha;
        private Point3D _center;

        public Prism()
        {
            _center = new Point3D(0, 0, 0);
            _length = 4.0f; // chieu dai cac canh mat day lang tru
            _height = 5.0f; // chieu cao cua lang tru
            _color = Color.White; // màu nền mặt phẳng
            _IsSelected = false; // kiểm tra có đang tương tác với hình hay không
            alpha = 2 * Math.PI / 3;
            Rbottom = Math.Sqrt(3) * _length / 3;
            listPoint3D = new List<Point3D>();
            type = 2;

            listPoint3D = new List<Point3D> { new Point3D(), new Point3D(), new Point3D(), new Point3D(), new Point3D(), new Point3D()};
            angleX = angleY = angleZ = 0;
            tX = tY = tZ = 0;
            sX = sY = sZ = 1;
        }

        private void Save()
        {
            listPoint3D.Clear();
            Rbottom = Math.Sqrt(3) * _length / 3;
            // Lưu tất cả đỉnh, hinh chay doc theo truc y
            Point3D P1, P2, P3, P4, P5, P6; //6 đỉnh
            // 3 diem dau la mot tam giac
            P1 = new Point3D(_center.x + Rbottom, _center.y - _height / 2, _center.z);
            P2 = new Point3D(_center.x + Rbottom * Math.Cos(alpha), _center.y - _height / 2, _center.z + Rbottom * Math.Sin(alpha));
            P3 = new Point3D(_center.x + Rbottom * Math.Cos(2 * alpha), _center.y - _height / 2, _center.z + Rbottom * Math.Sin(2 * alpha));
            // 3 diem con lai cung tao nen mot mat tam giac
            P4 = new Point3D(P1.x, _center.y + _height / 2, P1.z);
            P5 = new Point3D(P2.x, _center.y + _height / 2, P2.z);
            P6 = new Point3D(P3.x, _center.y + _height / 2, P3.z);

            listPoint3D.Add(P1);
            listPoint3D.Add(P2);
            listPoint3D.Add(P3);
            listPoint3D.Add(P4);
            listPoint3D.Add(P5);
            listPoint3D.Add(P6);
        }
        public override void Draw(OpenGLControl glControl)
        {
            OpenGL gl = glControl.OpenGL;
            Save();
            gl.PushMatrix();
            gl.Rotate((float)angleX, (float)angleY, (float)angleZ);
            gl.Translate(tX, tY, tZ);
            gl.Scale(sX, sY, sZ);

            gl.Color(_color.R / 255.0, _color.G / 255.0, _color.B / 255.0, 0);
            //Vẽ khối hoặc vẽ và dán texture
            if (isTexture)
                DrawTexture(gl);
            else
                DrawRaw(gl);
            Border(gl);
            gl.PopMatrix();
            gl.Flush();
        }
        public void DrawRaw(OpenGL gl)
        {
            gl.Begin(OpenGL.GL_TRIANGLES);
            // Ve mat tam giac
            gl.Vertex(listPoint3D[0].x, listPoint3D[0].y, listPoint3D[0].z); // P1
            gl.Vertex(listPoint3D[1].x, listPoint3D[1].y, listPoint3D[1].z); // P2
            gl.Vertex(listPoint3D[2].x, listPoint3D[2].y, listPoint3D[2].z); // P3

            gl.Vertex(listPoint3D[3].x, listPoint3D[3].y, listPoint3D[3].z); // P4
            gl.Vertex(listPoint3D[4].x, listPoint3D[4].y, listPoint3D[4].z); // P5
            gl.Vertex(listPoint3D[5].x, listPoint3D[5].y, listPoint3D[5].z); // P6

            gl.End();

            gl.Color(_color.R / 255.0, _color.G / 255.0, _color.B / 255.0, 0);
            gl.Begin(OpenGL.GL_QUADS);
            // Ve mat ben
            gl.Vertex(listPoint3D[0].x, listPoint3D[0].y, listPoint3D[0].z); // P1
            gl.Vertex(listPoint3D[1].x, listPoint3D[1].y, listPoint3D[1].z); // P2
            gl.Vertex(listPoint3D[4].x, listPoint3D[4].y, listPoint3D[4].z); // P5
            gl.Vertex(listPoint3D[3].x, listPoint3D[3].y, listPoint3D[3].z); // P4

            gl.Vertex(listPoint3D[0].x, listPoint3D[0].y, listPoint3D[0].z); // P1
            gl.Vertex(listPoint3D[2].x, listPoint3D[2].y, listPoint3D[2].z); // P3
            gl.Vertex(listPoint3D[5].x, listPoint3D[5].y, listPoint3D[5].z); // P6
            gl.Vertex(listPoint3D[3].x, listPoint3D[3].y, listPoint3D[3].z); // P4

            gl.Vertex(listPoint3D[1].x, listPoint3D[1].y, listPoint3D[1].z); // P2
            gl.Vertex(listPoint3D[2].x, listPoint3D[2].y, listPoint3D[2].z); // P3
            gl.Vertex(listPoint3D[5].x, listPoint3D[5].y, listPoint3D[5].z); // P6
            gl.Vertex(listPoint3D[4].x, listPoint3D[4].y, listPoint3D[4].z); // P5

            gl.End();
            gl.Flush();


        }

        private void DrawTexture(OpenGL gl)
        {
            gl.Enable(OpenGL.GL_TEXTURE_2D);
            // Bind the texture.
            texture.Bind(gl);
            gl.Color(1f, 1f, 1f, 0);
            gl.Begin(OpenGL.GL_QUADS);
            // Vẽ mặt phẳng
            // Top face
            gl.TexCoord(0.5f, 0.0f); gl.Vertex(listPoint3D[0].x, listPoint3D[0].y, listPoint3D[0].z); // P1
            gl.TexCoord(0.5f, 0.0f); gl.Vertex(listPoint3D[0].x, listPoint3D[0].y, listPoint3D[0].z); // P1
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(listPoint3D[1].x, listPoint3D[1].y, listPoint3D[1].z); // P2
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(listPoint3D[2].x, listPoint3D[2].y, listPoint3D[2].z); // P3
            // Bottom face
            gl.TexCoord(0.5f, 0.0f); gl.Vertex(listPoint3D[3].x, listPoint3D[3].y, listPoint3D[3].z); // P4
            gl.TexCoord(0.5f, 0.0f); gl.Vertex(listPoint3D[3].x, listPoint3D[3].y, listPoint3D[3].z); // P4
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(listPoint3D[4].x, listPoint3D[4].y, listPoint3D[4].z); // P5
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(listPoint3D[5].x, listPoint3D[5].y, listPoint3D[5].z); // P6
            // Surround face
            gl.TexCoord(1.0f, 0.0f); gl.Vertex(listPoint3D[5].x, listPoint3D[5].y, listPoint3D[5].z); // P6
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(listPoint3D[2].x, listPoint3D[2].y, listPoint3D[2].z); // P3
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(listPoint3D[0].x, listPoint3D[0].y, listPoint3D[0].z); // P1
            gl.TexCoord(0.0f, 0.0f); gl.Vertex(listPoint3D[3].x, listPoint3D[3].y, listPoint3D[3].z); // P4

            gl.TexCoord(1.0f, 0.0f); gl.Vertex(listPoint3D[4].x, listPoint3D[4].y, listPoint3D[4].z); // P5
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(listPoint3D[1].x, listPoint3D[1].y, listPoint3D[1].z); // P2
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(listPoint3D[2].x, listPoint3D[2].y, listPoint3D[2].z); // P3
            gl.TexCoord(0.0f, 0.0f); gl.Vertex(listPoint3D[5].x, listPoint3D[5].y, listPoint3D[5].z); // P6

            gl.TexCoord(1.0f, 0.0f); gl.Vertex(listPoint3D[3].x, listPoint3D[3].y, listPoint3D[3].z); // P4
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(listPoint3D[0].x, listPoint3D[0].y, listPoint3D[0].z); // P1
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(listPoint3D[1].x, listPoint3D[1].y, listPoint3D[1].z); // P2
            gl.TexCoord(0.0f, 0.0f); gl.Vertex(listPoint3D[4].x, listPoint3D[4].y, listPoint3D[4].z); // P5
            gl.End();
            Border(gl);
            gl.Disable(OpenGL.GL_TEXTURE_2D);
        }
        private void Border(OpenGL gl)
        {
            if (_IsSelected) // nếu đang tương tác trên hình
            {
                gl.Color(236 / 255.0, 135 / 255.0, 14 / 255.0); // viền cam đậm
                gl.LineWidth((float)2); // tăng kích cỡ viền
            }
            else // nếu không thao tác
            {
                gl.Color(255 / 255.0, 255 / 255.0, 255 / 255.0); // viền đen nhạt
                gl.LineWidth((float)2); // tăng kích cỡ viền
            }

            gl.Begin(OpenGL.GL_LINES);
            // Vẽ các cạnh
            gl.Vertex(listPoint3D[0].x, listPoint3D[0].y, listPoint3D[0].z); // P1
            gl.Vertex(listPoint3D[1].x, listPoint3D[1].y, listPoint3D[1].z); // P2

            gl.Vertex(listPoint3D[1].x, listPoint3D[1].y, listPoint3D[1].z); // P2
            gl.Vertex(listPoint3D[2].x, listPoint3D[2].y, listPoint3D[2].z); // P3

            gl.Vertex(listPoint3D[0].x, listPoint3D[0].y, listPoint3D[0].z); // P1
            gl.Vertex(listPoint3D[2].x, listPoint3D[2].y, listPoint3D[2].z); // P3

            gl.Vertex(listPoint3D[0].x, listPoint3D[0].y, listPoint3D[0].z); // P1
            gl.Vertex(listPoint3D[3].x, listPoint3D[3].y, listPoint3D[3].z); // P4

            gl.Vertex(listPoint3D[1].x, listPoint3D[1].y, listPoint3D[1].z); // P2
            gl.Vertex(listPoint3D[4].x, listPoint3D[4].y, listPoint3D[4].z); // P5

            gl.Vertex(listPoint3D[2].x, listPoint3D[2].y, listPoint3D[2].z); // P3
            gl.Vertex(listPoint3D[5].x, listPoint3D[5].y, listPoint3D[5].z); // P6

            gl.Vertex(listPoint3D[3].x, listPoint3D[3].y, listPoint3D[3].z); // P4
            gl.Vertex(listPoint3D[4].x, listPoint3D[4].y, listPoint3D[4].z); // P5

            gl.Vertex(listPoint3D[5].x, listPoint3D[5].y, listPoint3D[5].z); // P6
            gl.Vertex(listPoint3D[3].x, listPoint3D[3].y, listPoint3D[3].z); // P4

            gl.Vertex(listPoint3D[5].x, listPoint3D[5].y, listPoint3D[5].z); // P6
            gl.Vertex(listPoint3D[4].x, listPoint3D[4].y, listPoint3D[4].z); // P5

            gl.End();
        }

        ~Prism()
        {
        }
    }
}
