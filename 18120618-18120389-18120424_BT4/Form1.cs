using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpGL;
using SharpGL.SceneGraph.Assets;

namespace Lab04
{
    public partial class SharpGLFrom : Form
    {
        Camera cam = new Camera();
        OpenFileDialog openfd = new OpenFileDialog();
        static int choice = 0;
        Background background = new Background();
        bool existObject = false;


        bool newobject = false; //Kiểm tra xem có tạo hình mới không
        int check = -1;
        public SharpGLFrom()
        {
            InitializeComponent();
        }
        private void openGLControl_OpenGLInitialized(object sender, EventArgs e)
        {
            // Get the OpenGL object.
            OpenGL gl = openGLControl.OpenGL;
            // Set the clear color.
            gl.ClearColor(0, 0, 0, 0);
            // Set the projection matrix.
            gl.MatrixMode(OpenGL.GL_PROJECTION);
            btnStickTexture.Enabled = false;
            btnOpenTextureFile.Enabled = false;
            btnRemoveTexture.Enabled = false;
            // Load the identity.
            gl.LoadIdentity();
        }
        private void openGLControl_Resized(object sender, EventArgs e)
        {
            // Get the OpenGL object.
            OpenGL gl = openGLControl.OpenGL;
            // Set the Model_view matrix.
            gl.MatrixMode(OpenGL.GL_MODELVIEW);
            // Create a perspective transformation.
            gl.LookAt(cam._eyeX, cam._eyeY, cam._eyeZ, cam._viewX, cam._viewY, cam._viewZ, 0, 1, 0);
            gl.MatrixMode(OpenGL.GL_PROJECTION);
            gl.Perspective(60, openGLControl.Width * 1f / openGLControl.Height, 1, 50);
            gl.Viewport(0, 0, openGLControl.Width, openGLControl.Height);
        }

        private void openGLControl_OpenGLDraw(object sender, RenderEventArgs args)
        {
            OpenGL gl = openGLControl.OpenGL;
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

            // Set the projection matrix.
            gl.MatrixMode(OpenGL.GL_MODELVIEW);
            // Load the identity.
            gl.LoadIdentity();
            // Create a perspective transformation.
            gl.LookAt(cam._eyeX, cam._eyeY, cam._eyeZ, cam._viewX, cam._viewY, cam._viewZ, 0, 1, 0);

            background.Draw(openGLControl, 100);

            // Nếu đang chọn hình để vẽ
            if (newobject)
            {
                if (check != -1)
                {
                    Draw.listObject[check]._IsSelected = false;
                    check = -1;
                }
                Point3D center = new Point3D(0, 0, 0);
                Draw.chooseObject(openGLControl, choice, center);
                lboxObjectsList.Items.Add(Draw.listObject[Draw.listObject.Count - 1]);
                lboxObjectsList.DisplayMember = "Name";
                newobject = false;
            }

            Draw.DrawShape(openGLControl);

            gl.Flush();

            lbCamPosX.Text = Math.Round(cam._eyeX, 3).ToString();
            lbCamPosY.Text = Math.Round(cam._eyeY, 3).ToString();
            lbCamPosZ.Text = Math.Round(cam._eyeZ, 3).ToString();
        }

        // Chọn màu
        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                if (check != -1)
                    Draw.listObject[check]._color = colorDialog1.Color;
            }
        }

        // Thao tac Camera
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            OpenGL gl = openGLControl.OpenGL;

            if (keyData == Keys.Z) // Phím Z phóng to
            {
                cam.ZoomIn();
            }
            else if (keyData == Keys.X) // Phím X thu nhỏ
            {
                cam.ZoomOut();
            }
            else if (keyData == Keys.Left) // Phím <- xoay trái
            {
                cam.RotateLeft();
            }
            else if (keyData == Keys.Right) // Phím -> xoay phải
            {
                cam.RotateRight();
            }
            else if (keyData == Keys.Up) // Phím mũi tên trên xoay lên
            {
                cam.RotateUp();
            }
            else if (keyData == Keys.Down) // Phím mũi tên dưới xoay xuống
            {
                cam.RotateDown();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        // Nút chọn vẽ Cube
        private void btnCube_Click(object sender, EventArgs e)
        {
            newobject = true;
            choice = 1;
            Object._countObjects++;
        }

        // Nút chọn vẽ Pyramid 
        private void btnPyramid_Click(object sender, EventArgs e)
        {
            newobject = true;
            choice = 2;
            Object._countObjects++;
        }

        // Nút chọn vẽ Prism
        private void btnPrism_Click(object sender, EventArgs e)
        {
            newobject = true;
            choice = 3;
            Object._countObjects++;
        }

        // Xử lý sự kiện click vào List object
        private void lboxObjectsList_MouseClick(object sender, MouseEventArgs e)
        {
            // Get vị trí click chuột
            int index = this.lboxObjectsList.IndexFromPoint(e.Location);
            // Nếu chưa có đối tượng nào được tạo và chọn
            if (existObject == false && index != -1)
            {
                // Bật textbox length của đối tượng được chọn
                txtboxLength.Enabled = true;

                // Bật text box scale của đối tượng được chọn
                txtboxSX.Enabled = true;
                txtboxSY.Enabled = true;
                txtboxSZ.Enabled = true;

                // Bật text box position của đối tượng được chọn
                txtboxPX.Enabled = true;
                txtboxPY.Enabled = true;
                txtboxPZ.Enabled = true;

                // Bật text box rotate của đối tượng được chọn
                txtboxRX.Enabled = true;
                txtboxRY.Enabled = true;
                txtboxRZ.Enabled = true;

                existObject = true;

                btnOpenTextureFile.Enabled = true;
            }

            // Nếu click vào 1 vị trí khác trong List object
            if (check != index && index >= 0)
            {
                // Vị trí đó là tên 1 đối tượng
                if (check != -1)
                {
                    // Sửa lại đường viền màu nhạt cho đối tượng trước đó
                    Draw.listObject[check]._IsSelected = false;
                }
                // Đổi đường viền đối tượng mới được chọn sang màu cam đậm
                Draw.listObject[index]._IsSelected = true;
                // Gán lại check cho những lần xử lý tiếp theo
                check = index;

                // Hiển thị length của đối tượng được chọn
                txtboxLength.Text = Draw.listObject[index]._length.ToString();

                // Hiển thị tỉ lệ hiện tại của hình được chọn vào hàng Scale
                txtboxSX.Text = Draw.listObject[index].sX.ToString();
                txtboxSY.Text = Draw.listObject[index].sY.ToString();
                txtboxSZ.Text = Draw.listObject[index].sZ.ToString();

                // Hiển thị vị trí hiện tại của hình được chọn vào hàng Position
                txtboxPX.Text = Draw.listObject[index].tX.ToString();
                txtboxPY.Text = Draw.listObject[index].tY.ToString();
                txtboxPZ.Text = Draw.listObject[index].tZ.ToString();

                // Hiển thị góc xoay hiện tại của hình được chọn vào hàng Rotation
                txtboxRX.Text = Draw.listObject[index].angleX.ToString();
                txtboxRY.Text = Draw.listObject[index].angleY.ToString();
                txtboxRZ.Text = Draw.listObject[index].angleZ.ToString();

                // Nếu là Cube, chỉ bật thuộc tính length
                if (Draw.listObject[index].type == 0)
                {
                    txtboxHeight.Enabled = false;
                }
                // Ngược lại - là Pyramid/Prism - bật length và height
                else
                {
                    txtboxHeight.Enabled = true;
                    txtboxHeight.Text = Draw.listObject[index]._height.ToString();
                }
                btnOpenTextureFile.Enabled = true;
            }
        }

        // Set length
        private void btnSetLength_Click(object sender, EventArgs e)
        {
            if (check != -1)
            {
                double length;
                if (double.TryParse(txtboxLength.Text, out length))
                {
                    Draw.listObject[check]._length = length;
                }
                else
                {
                    txtboxLength.Text = "4";
                    Draw.listObject[check]._length = 4;
                }
                txtboxRX.Text = "";
                txtboxRY.Text = "";
                txtboxRZ.Text = "";
                txtboxSX.Text = ""; 
                txtboxSY.Text = "";
                txtboxSZ.Text = "";
                txtboxPX.Text = "";
                txtboxPY.Text = "";
                txtboxPZ.Text = "";
            }
        }

        // Set height
        private void btnSetHeight_Click(object sender, EventArgs e)
        {
            if (check != -1)
            {
                double height;
                if (double.TryParse(txtboxHeight.Text, out height))
                {
                    Draw.listObject[check]._height = height;
                }
                else
                {
                    txtboxHeight.Text = "5";
                    Draw.listObject[check]._height = 5;
                }
                txtboxRX.Text = "0";
                txtboxRY.Text = "0";
                txtboxRZ.Text = "0";
                txtboxSX.Text = "1";
                txtboxSY.Text = "1";
                txtboxSZ.Text = "1";
                txtboxPX.Text = "0";
                txtboxPY.Text = "0";
                txtboxPZ.Text = "0";
            }
        }

        // Thay đổi vị trí đối tượng
        private void btnPosition_Click(object sender, EventArgs e)
        {
            if (existObject == true)
            {
                if (double.TryParse(txtboxPX.Text, out double tX) &&
                double.TryParse(txtboxPY.Text, out double tY) &&
                double.TryParse(txtboxPZ.Text, out double tZ))
                {
                    Draw.listObject[check].tX = tX;
                    Draw.listObject[check].tY = tY;
                    Draw.listObject[check].tZ = tZ;
                }
                else
                {
                    txtboxPX.Text = "0";
                    txtboxPY.Text = "0";
                    txtboxPZ.Text = "0";
                    Draw.listObject[check].tX = 0;
                    Draw.listObject[check].tY = 0;
                    Draw.listObject[check].tZ = 0;
                }

            }
        }

        // Thay đổi tỉ lệ theo các trục
        private void btnScale_Click(object sender, EventArgs e)
        {
            if (existObject == true)
            {
                if (double.TryParse(txtboxSX.Text, out double sX) &&
                    double.TryParse(txtboxSY.Text, out double sY) &&
                    double.TryParse(txtboxSZ.Text, out double sZ))
                {
                    Draw.listObject[check].sX = sX;
                    Draw.listObject[check].sY = sY;
                    Draw.listObject[check].sZ = sZ;
                }
                else
                {
                    txtboxSX.Text = "1";
                    txtboxSY.Text = "1";
                    txtboxSZ.Text = "1";
                    Draw.listObject[check].sX = 1;
                    Draw.listObject[check].sY = 1;
                    Draw.listObject[check].sZ = 1;
                }
                txtboxLength.Text = "";
                txtboxHeight.Text = "";
            }
        }

        // Xoay đối tượng
        private void btnRotation_Click(object sender, EventArgs e)
        {
            if (existObject == true)
            {
                if (double.TryParse(txtboxRX.Text, out double angleX) &&
                double.TryParse(txtboxRY.Text, out double angleY) &&
                double.TryParse(txtboxRZ.Text, out double angleZ))
                {
                    Draw.listObject[check].angleX = angleX;
                    Draw.listObject[check].angleY = angleY;
                    Draw.listObject[check].angleZ = angleZ;
                }
                else
                {
                    txtboxRX.Text = "0";
                    txtboxRY.Text = "0";
                    txtboxRZ.Text = "0";
                    Draw.listObject[check].angleX = 0;
                    Draw.listObject[check].angleY = 0;
                    Draw.listObject[check].angleZ = 0;
                }
            }
        }

        // Chọn hình để dán texture
        private void btnOpenTextureFile_Click(object sender, EventArgs e)
        {
            if (check != -1)
            {
                if (openfd.ShowDialog() == DialogResult.OK)
                {
                    txtboxTexturePath.Text = openfd.FileName.ToString();
                    ptboxShowTexture.BackgroundImage = Image.FromFile(txtboxTexturePath.Text);
                    ptboxShowTexture.BackgroundImageLayout = ImageLayout.Stretch;
                    btnStickTexture.Enabled = true;
                    btnRemoveTexture.Enabled = true;
                }
            }
        }

        // Dán Texture theo đường dẫn đã chọn
        private void btnStickTexture_Click(object sender, EventArgs e)
        {
            if (check != -1)
            {
                Draw.listObject[check].isTexture = true;
                Texture texture = new Texture();
                texture.Create(openGLControl.OpenGL, txtboxTexturePath.Text);
                Draw.listObject[check].texture = texture;
            }
        }

        // Bỏ dán texture 
        private void btnRemoveTexture_Click(object sender, EventArgs e)
        {
            if (check != -1)
            {
                Draw.listObject[check].isTexture = false;
                ptboxShowTexture.BackgroundImage = null;
                txtboxTexturePath.Text = "";
                btnStickTexture.Enabled = false;
                btnRemoveTexture.Enabled = false;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < Draw.listObject.Count; i++)
            {
                if(Draw.listObject[i]._IsSelected)
                {
                    Draw.listObject.RemoveAt(i);
                    lboxObjectsList.Items.RemoveAt(i);
                    Object._countObjects--;
                    txtboxRX.Text = "";
                    txtboxRY.Text = "";
                    txtboxRZ.Text = "";
                    txtboxSX.Text = "";
                    txtboxSY.Text = "";
                    txtboxSZ.Text = "";
                    txtboxPX.Text = "";
                    txtboxPY.Text = "";
                    txtboxPZ.Text = "";
                    txtboxLength.Text = "";
                    txtboxHeight.Text = "";
                    newobject = false;
                    choice = 0;
                    check = -1;
                    btnOpenTextureFile.Enabled = false;
                    btnStickTexture.Enabled = false;
                    btnRemoveTexture.Enabled = false;
                    ptboxShowTexture.BackgroundImage = null;
                    txtboxTexturePath.Text = "";
                }
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            Draw.listObject.Clear();
            lboxObjectsList.Items.Clear();
            txtboxRX.Text = "";
            txtboxRY.Text = "";
            txtboxRZ.Text = "";
            txtboxSX.Text = "";
            txtboxSY.Text = "";
            txtboxSZ.Text = "";
            txtboxPX.Text = "";
            txtboxPY.Text = "";
            txtboxPZ.Text = "";
            txtboxLength.Text = "";
            txtboxHeight.Text = "";
            newobject = false;
            choice = 0;
            check = -1;
            Object._countObjects = 0;
            btnOpenTextureFile.Enabled = false;
            btnStickTexture.Enabled = false;
            btnRemoveTexture.Enabled = false;
            ptboxShowTexture.BackgroundImage = null;
            txtboxTexturePath.Text = "";
        }
    }
}
