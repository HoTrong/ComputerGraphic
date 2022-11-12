
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using SharpGL.SceneGraph;
using SharpGL;
using SharpGL.SceneGraph.Assets;

namespace Lab04
{
    class Cube : Object
    {
        private Point3D delta;
        public Cube()
        {
            _length = 4.0f;
            _height = 4.0f;
            _color = Color.White; // màu nền mặt phẳng
            delta = new Point3D(tX - 0 - _length / 2, tY - 0 - _length / 2, tZ - 0 - _length / 2);
            _IsSelected = false; // kiểm tra có đang tương tác với hình hay không
            type = 0;
            isTexture = false;
            texture = new Texture();

            listPoint3D = new List<Point3D> { new Point3D(), new Point3D(), new Point3D(), new Point3D(), new Point3D(), new Point3D(), new Point3D(), new Point3D() };
            angleX = angleY = angleZ = 0;
            tX = tY = tZ = 0;
            sX = sY = sZ = 1;

        }
        private void Save()
        {
            delta.x = tX - 0 - _length / 2;
            delta.y = tY - 0 - _length / 2;
            delta.z = tZ - 0 - _length / 2;

            // P1 = new Point3D(0 + delta.x, 0 + delta.y, 0 + delta.z);
            listPoint3D[0].x = 0 + delta.x;
            listPoint3D[0].y = 0 + delta.y;
            listPoint3D[0].z = 0 + delta.z;
            // P2 = new Point3D(0 + delta.x, _length + delta.y, 0 + delta.z);
            listPoint3D[1].x = 0 + delta.x;
            listPoint3D[1].y = _length + delta.y;
            listPoint3D[1].z = 0 + delta.z;
            // P3 = new Point3D(_length + delta.x, _length + delta.y, 0 + delta.z);
            listPoint3D[2].x = _length + delta.x;
            listPoint3D[2].y = _length + delta.y;
            listPoint3D[2].z = 0 + delta.z;
            // P4 = new Point3D(_length + delta.x, 0 + delta.y, 0 + delta.z);
            listPoint3D[3].x = _length + delta.x;
            listPoint3D[3].y = 0 + delta.y;
            listPoint3D[3].z = 0 + delta.z;
            // P5 = new Point3D(0 + delta.x, _length + delta.y, _length + delta.z);
            listPoint3D[4].x = 0 + delta.x;
            listPoint3D[4].y = _length + delta.y;
            listPoint3D[4].z = _length + delta.z;
            // P6 = new Point3D(0 + delta.x, 0 + delta.y, _length + delta.z);
            listPoint3D[5].x = 0 + delta.x;
            listPoint3D[5].y = 0 + delta.y;
            listPoint3D[5].z = _length + delta.z;
            // P7 = new Point3D(_length + delta.x, 0 + delta.y, _length + delta.z);
            listPoint3D[6].x = _length + delta.x;
            listPoint3D[6].y = 0 + delta.y;
            listPoint3D[6].z = _length + delta.z;
            // P8 = new Point3D(_length + delta.x, _length + delta.y, _length + delta.z);
            listPoint3D[7].x = _length + delta.x;
            listPoint3D[7].y = _length + delta.y;
            listPoint3D[7].z = _length + delta.z;
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
            // Vẽ khối hoặc vẽ và dán texture
            if (isTexture)
                DrawTexture(gl);
            else
                DrawRaw(gl);
            // Viền khung
            Border(gl);
            gl.PopMatrix();
            gl.Flush();
        }

        private void DrawRaw(OpenGL gl)
        {
            gl.Begin(OpenGL.GL_QUADS);
            // Vẽ mặt phẳng
            gl.Vertex(0 + delta.x, 0 + delta.y, 0 + delta.z);//P1
            gl.Vertex(0 + delta.x, _length + delta.y, 0 + delta.z);//P2
            gl.Vertex(_length + delta.x, _length + delta.y, 0 + delta.z); //P3
            gl.Vertex(_length + delta.x, 0 + delta.y, 0 + delta.z); //P4


            gl.Vertex(0 + delta.x, 0 + delta.y, 0 + delta.z); //P1
            gl.Vertex(0 + delta.x, _length + delta.y, 0 + delta.z); //P2
            gl.Vertex(0 + delta.x, _length + delta.y, _length + delta.z);//P5
            gl.Vertex(0 + delta.x, 0 + delta.y, _length + delta.z);//P6


            gl.Vertex(0 + delta.x, 0 + delta.y, 0 + delta.z); //P1
            gl.Vertex(0 + delta.x, 0 + delta.y, _length + delta.z);//P6
            gl.Vertex(_length + delta.x, 0 + delta.y, _length + delta.z);//P7
            gl.Vertex(_length + delta.x, 0 + delta.y, 0 + delta.z);//P4

            gl.Vertex(0 + delta.x, 0 + delta.y, _length + delta.z);//P6
            gl.Vertex(0 + delta.x, _length + delta.y, _length + delta.z);//P5
            gl.Vertex(_length + delta.x, _length + delta.y, _length + delta.z);//P8
            gl.Vertex(_length + delta.x, 0 + delta.y, _length + delta.z);//P7


            gl.Vertex(0 + delta.x, _length + delta.y, 0 + delta.z);//P2
            gl.Vertex(0 + delta.x, _length + delta.y, _length + delta.z);//P5
            gl.Vertex(_length + delta.x, _length + delta.y, _length + delta.z);//P8
            gl.Vertex(_length + delta.x, _length + delta.y, 0 + delta.z);//P3


            gl.Vertex(_length + delta.x, _length + delta.y, 0 + delta.z);//P3
            gl.Vertex(_length + delta.x, 0 + delta.y, 0 + delta.z);//P4
            gl.Vertex(_length + delta.x, 0 + delta.y, _length + delta.z);//P7
            gl.Vertex(_length + delta.x, _length + delta.y, _length + delta.z);//P8

            gl.End();
        }

        private void DrawTexture(OpenGL gl)
        {
            gl.Enable(OpenGL.GL_TEXTURE_2D);
            // Bind the texture.
            texture.Bind(gl);
            gl.Color(1f, 1f, 1f, 0);
            gl.Begin(OpenGL.GL_QUADS);
            // Vẽ mặt phẳng
            // Right face
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(0 + delta.x, 0 + delta.y, 0 + delta.z);//P1
            gl.TexCoord(1.0f, 0.0f); gl.Vertex(0 + delta.x, _length + delta.y, 0 + delta.z);//P2
            gl.TexCoord(0.0f, 0.0f); gl.Vertex(_length + delta.x, _length + delta.y, 0 + delta.z); //P3
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(_length + delta.x, 0 + delta.y, 0 + delta.z); //P4

            // Back face
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(0 + delta.x, 0 + delta.y, 0 + delta.z); //P1
            gl.TexCoord(0.0f, 0.0f); gl.Vertex(0 + delta.x, _length + delta.y, 0 + delta.z); //P2
            gl.TexCoord(1.0f, 0.0f); gl.Vertex(0 + delta.x, _length + delta.y, _length + delta.z);//P5
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(0 + delta.x, 0 + delta.y, _length + delta.z);//P6

            // Bottom face
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(0 + delta.x, 0 + delta.y, 0 + delta.z); //P1
            gl.TexCoord(0.0f, 0.0f); gl.Vertex(0 + delta.x, 0 + delta.y, _length + delta.z);//P6
            gl.TexCoord(1.0f, 0.0f); gl.Vertex(_length + delta.x, 0 + delta.y, _length + delta.z);//P7
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(_length + delta.x, 0 + delta.y, 0 + delta.z);//P4

            // Left face
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(0 + delta.x, 0 + delta.y, _length + delta.z);//P6
            gl.TexCoord(0.0f, 0.0f); gl.Vertex(0 + delta.x, _length + delta.y, _length + delta.z);//P5
            gl.TexCoord(1.0f, 0.0f); gl.Vertex(_length + delta.x, _length + delta.y, _length + delta.z);//P8
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(_length + delta.x, 0 + delta.y, _length + delta.z);//P7

            // Top face
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(0 + delta.x, _length + delta.y, 0 + delta.z);//P2
            gl.TexCoord(0.0f, 0.0f); gl.Vertex(0 + delta.x, _length + delta.y, _length + delta.z);//P5
            gl.TexCoord(1.0f, 0.0f); gl.Vertex(_length + delta.x, _length + delta.y, _length + delta.z);//P8
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(_length + delta.x, _length + delta.y, 0 + delta.z);//P3

            // Front face
            gl.TexCoord(1.0f, 0.0f); gl.Vertex(_length + delta.x, _length + delta.y, 0 + delta.z);//P3
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(_length + delta.x, 0 + delta.y, 0 + delta.z);//P4
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(_length + delta.x, 0 + delta.y, _length + delta.z);//P7
            gl.TexCoord(0.0f, 0.0f); gl.Vertex(_length + delta.x, _length + delta.y, _length + delta.z);//P8

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
            // Vẽ các cạnh
            gl.Vertex(listPoint3D[0].x, listPoint3D[0].y, listPoint3D[0].z);
            gl.Vertex(listPoint3D[1].x, listPoint3D[1].y, listPoint3D[1].z);

            gl.Vertex(listPoint3D[1].x, listPoint3D[1].y, listPoint3D[1].z);
            gl.Vertex(listPoint3D[2].x, listPoint3D[2].y, listPoint3D[2].z);


            gl.Vertex(listPoint3D[2].x, listPoint3D[2].y, listPoint3D[2].z);
            gl.Vertex(listPoint3D[3].x, listPoint3D[3].y, listPoint3D[3].z);


            gl.Vertex(listPoint3D[0].x, listPoint3D[0].y, listPoint3D[0].z);
            gl.Vertex(listPoint3D[3].x, listPoint3D[3].y, listPoint3D[3].z);


            gl.Vertex(listPoint3D[1].x, listPoint3D[1].y, listPoint3D[1].z);
            gl.Vertex(listPoint3D[4].x, listPoint3D[4].y, listPoint3D[4].z);


            gl.Vertex(listPoint3D[5].x, listPoint3D[5].y, listPoint3D[5].z);
            gl.Vertex(listPoint3D[4].x, listPoint3D[4].y, listPoint3D[4].z);


            gl.Vertex(listPoint3D[5].x, listPoint3D[5].y, listPoint3D[5].z);
            gl.Vertex(listPoint3D[0].x, listPoint3D[0].y, listPoint3D[0].z);


            gl.Vertex(listPoint3D[5].x, listPoint3D[5].y, listPoint3D[5].z);
            gl.Vertex(listPoint3D[6].x, listPoint3D[6].y, listPoint3D[6].z);


            gl.Vertex(listPoint3D[3].x, listPoint3D[3].y, listPoint3D[3].z);
            gl.Vertex(listPoint3D[6].x, listPoint3D[6].y, listPoint3D[6].z);


            gl.Vertex(listPoint3D[4].x, listPoint3D[4].y, listPoint3D[4].z);
            gl.Vertex(listPoint3D[7].x, listPoint3D[7].y, listPoint3D[7].z);


            gl.Vertex(listPoint3D[6].x, listPoint3D[6].y, listPoint3D[6].z);
            gl.Vertex(listPoint3D[7].x, listPoint3D[7].y, listPoint3D[7].z);



            gl.Vertex(listPoint3D[2].x, listPoint3D[2].y, listPoint3D[2].z);
            gl.Vertex(listPoint3D[7].x, listPoint3D[7].y, listPoint3D[7].z);
            gl.End();

        }

        ~Cube()
        {
        }
    }
}
