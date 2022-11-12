using SharpGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpGL.SceneGraph.Assets;

namespace Lab04
{
    class Pyramid : Object
    {
        public Point3D _center;
        public Pyramid()
        {
            _center = new Point3D(0, 0, 0); //tâm (mặc định (0,0,0))
            _length = 4.0f; //độ dài cạnh
            _height = 5.0f;
            _color = Color.White; //màu nền mặt phẳng
            _IsSelected = false; //kiểm tra có đang tương tác với hình hay không
            type = 1;
            isTexture = false;
            texture = new Texture();

            listPoint3D = new List<Point3D> { new Point3D(), new Point3D(), new Point3D(), new Point3D(), new Point3D()};
            angleX = angleY = angleZ = 0;
            tX = tY = tZ = 0;
            sX = sY = sZ = 1;
        }
        private void Save()
        {
            Point3D P1, P2, P3, P4, P5; // 5 dinh cua hinh
            listPoint3D = new List<Point3D>();
            double d = (2 * _height * _height - _length * _length) / (4 * _height);

            //dinh chop
            P1 = new Point3D(_center.x, _center.y + _height - d, _center.z);
            // 4 dinh mat day
            P2 = new Point3D(_center.x + _length / 2, _center.y - d, _center.z + _length / 2);
            P3 = new Point3D(_center.x + _length / 2, _center.y - d, _center.z - _length / 2);
            P4 = new Point3D(_center.x - _length / 2, _center.y - d, _center.z - _length / 2);
            P5 = new Point3D(_center.x - _length / 2, _center.y - d, _center.z + _length / 2);
            //luu lai cac diem
            listPoint3D.Add(P1);
            listPoint3D.Add(P2);
            listPoint3D.Add(P3);
            listPoint3D.Add(P4);
            listPoint3D.Add(P5);
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

        private void DrawRaw(OpenGL gl)
        {
            gl.Begin(OpenGL.GL_QUADS);
            //Ve mat day
            gl.Vertex(listPoint3D[1].x, listPoint3D[1].y, listPoint3D[1].z); // P2
            gl.Vertex(listPoint3D[2].x, listPoint3D[2].y, listPoint3D[2].z); // P3
            gl.Vertex(listPoint3D[3].x, listPoint3D[3].y, listPoint3D[3].z); // P4
            gl.Vertex(listPoint3D[4].x, listPoint3D[4].y, listPoint3D[4].z); // P5

            gl.End();
            //Ve mat ben la 4 tam giac
            gl.Begin(OpenGL.GL_TRIANGLES);

            gl.Vertex(listPoint3D[0].x, listPoint3D[0].y, listPoint3D[0].z); // P1
            gl.Vertex(listPoint3D[1].x, listPoint3D[1].y, listPoint3D[1].z); // P2
            gl.Vertex(listPoint3D[2].x, listPoint3D[2].y, listPoint3D[2].z); // P3

            gl.Vertex(listPoint3D[0].x, listPoint3D[0].y, listPoint3D[0].z); // P1
            gl.Vertex(listPoint3D[2].x, listPoint3D[2].y, listPoint3D[2].z); // P3
            gl.Vertex(listPoint3D[3].x, listPoint3D[3].y, listPoint3D[3].z); // P4

            gl.Vertex(listPoint3D[0].x, listPoint3D[0].y, listPoint3D[0].z); // P1
            gl.Vertex(listPoint3D[3].x, listPoint3D[3].y, listPoint3D[3].z); // P4
            gl.Vertex(listPoint3D[4].x, listPoint3D[4].y, listPoint3D[4].z); // P5

            gl.Vertex(listPoint3D[0].x, listPoint3D[0].y, listPoint3D[0].z); // P1
            gl.Vertex(listPoint3D[4].x, listPoint3D[4].y, listPoint3D[4].z); // P5
            gl.Vertex(listPoint3D[1].x, listPoint3D[1].y, listPoint3D[1].z); // P2

            gl.End();
        }

        private void DrawTexture(OpenGL gl)
        {
            gl.Enable(OpenGL.GL_TEXTURE_2D);
            //Bind the texture.
            texture.Bind(gl);
            gl.Color(1f, 1f, 1f, 0);
            gl.Begin(OpenGL.GL_QUADS);
            // Bottom face
            gl.TexCoord(0.0f, 0.0f); gl.Vertex(listPoint3D[1].x, listPoint3D[1].y, listPoint3D[1].z); // P2
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(listPoint3D[2].x, listPoint3D[2].y, listPoint3D[2].z); // P3
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(listPoint3D[3].x, listPoint3D[3].y, listPoint3D[3].z); // P4
            gl.TexCoord(1.0f, 0.0f); gl.Vertex(listPoint3D[4].x, listPoint3D[4].y, listPoint3D[4].z); // P5

            //Ve mat ben la 4 tam giac
            // Front face
            gl.TexCoord(0.5f, 0.0f); gl.Vertex(listPoint3D[0].x, listPoint3D[0].y, listPoint3D[0].z); // P1
            gl.TexCoord(0.5f, 0.0f); gl.Vertex(listPoint3D[0].x, listPoint3D[0].y, listPoint3D[0].z); // P1
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(listPoint3D[1].x, listPoint3D[1].y, listPoint3D[1].z); // P2
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(listPoint3D[2].x, listPoint3D[2].y, listPoint3D[2].z); // P3

            // Right face
            gl.TexCoord(0.5f, 0.0f); gl.Vertex(listPoint3D[0].x, listPoint3D[0].y, listPoint3D[0].z); // P1
            gl.TexCoord(0.5f, 0.0f); gl.Vertex(listPoint3D[0].x, listPoint3D[0].y, listPoint3D[0].z); // P1
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(listPoint3D[2].x, listPoint3D[2].y, listPoint3D[2].z); // P3
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(listPoint3D[3].x, listPoint3D[3].y, listPoint3D[3].z); // P4
            // Back face
            gl.TexCoord(0.5f, 0.0f); gl.Vertex(listPoint3D[0].x, listPoint3D[0].y, listPoint3D[0].z); // P1
            gl.TexCoord(0.5f, 0.0f); gl.Vertex(listPoint3D[0].x, listPoint3D[0].y, listPoint3D[0].z); // P1
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(listPoint3D[3].x, listPoint3D[3].y, listPoint3D[3].z); // P4
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(listPoint3D[4].x, listPoint3D[4].y, listPoint3D[4].z); // P5
            // Left face
            gl.TexCoord(0.5f, 0.0f); gl.Vertex(listPoint3D[0].x, listPoint3D[0].y, listPoint3D[0].z); // P1
            gl.TexCoord(0.5f, 0.0f); gl.Vertex(listPoint3D[0].x, listPoint3D[0].y, listPoint3D[0].z); // P1
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(listPoint3D[4].x, listPoint3D[4].y, listPoint3D[4].z); // P5
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(listPoint3D[1].x, listPoint3D[1].y, listPoint3D[1].z); // P2

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
            else // ngược lại
            {
                gl.Color(255 / 255.0, 255 / 255.0, 255 / 255.0); // viền đen nhạt
                gl.LineWidth((float)2); // tăng kích cỡ viền
            }

            gl.Begin(OpenGL.GL_LINES);
            //Vẽ các cạnh
            gl.Vertex(listPoint3D[0].x, listPoint3D[0].y, listPoint3D[0].z); // P1
            gl.Vertex(listPoint3D[1].x, listPoint3D[1].y, listPoint3D[1].z); // P2

            gl.Vertex(listPoint3D[0].x, listPoint3D[0].y, listPoint3D[0].z); // P1
            gl.Vertex(listPoint3D[2].x, listPoint3D[2].y, listPoint3D[2].z); // P3

            gl.Vertex(listPoint3D[0].x, listPoint3D[0].y, listPoint3D[0].z); // P1
            gl.Vertex(listPoint3D[3].x, listPoint3D[3].y, listPoint3D[3].z); // P4

            gl.Vertex(listPoint3D[0].x, listPoint3D[0].y, listPoint3D[0].z); // P1
            gl.Vertex(listPoint3D[4].x, listPoint3D[4].y, listPoint3D[4].z); // P5

            gl.Vertex(listPoint3D[1].x, listPoint3D[1].y, listPoint3D[1].z); // P2
            gl.Vertex(listPoint3D[2].x, listPoint3D[2].y, listPoint3D[2].z); // P3

            gl.Vertex(listPoint3D[2].x, listPoint3D[2].y, listPoint3D[2].z); // P3
            gl.Vertex(listPoint3D[3].x, listPoint3D[3].y, listPoint3D[3].z); // P4

            gl.Vertex(listPoint3D[3].x, listPoint3D[3].y, listPoint3D[3].z); // P4
            gl.Vertex(listPoint3D[4].x, listPoint3D[4].y, listPoint3D[4].z); // P5

            gl.Vertex(listPoint3D[4].x, listPoint3D[4].y, listPoint3D[4].z); // P5
            gl.Vertex(listPoint3D[1].x, listPoint3D[1].y, listPoint3D[1].z); // P2

            gl.End();
        }
        ~Pyramid() { }
    }
}
