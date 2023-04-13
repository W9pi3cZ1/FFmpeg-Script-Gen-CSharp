namespace MyCSharpProject
{
    public partial class Form1 : Form
    {
        private float X;
        private float Y;
        public Form1()
        {
            InitializeComponent();
        }

        private void setTag(Control cons)
        {
            foreach (Control con in cons.Controls)//ѭ�������еĿؼ�
            {
                con.Tag = con.Width + ":" + con.Height + ":" + con.Left + ":" + con.Top + ":" + con.Font.Size;
                if (con.Controls.Count > 0)
                    setTag(con);
            }
        }

        /// <summary>
        /// ���ݴ����С�����ؼ���С
        /// </summary>
        /// <param name="newx">���������ű���</param>
        /// <param name="newy">����߶����ű���</param>
        /// <param name="cons">�洰��ı�ؼ���С</param>
        private void setControls(float newx, float newy, Control cons)
        {
            //���������еĿؼ����������ÿؼ���ֵ
            foreach (Control con in cons.Controls)
            {

                string[] mytag = con.Tag.ToString().Split(new char[] { ':' });//��ȡ�ؼ���Tag����ֵ�����ָ��洢�ַ�������
                float a = System.Convert.ToSingle(mytag[0]) * newx;//���ݴ������ű���ȷ���ؼ���ֵ�����
                con.Width = (int)a;//���
                a = System.Convert.ToSingle(mytag[1]) * newy;//�߶�
                con.Height = (int)(a);
                a = System.Convert.ToSingle(mytag[2]) * newx;//��߾���
                con.Left = (int)(a);
                a = System.Convert.ToSingle(mytag[3]) * newy;//�ϱ�Ե����
                con.Top = (int)(a);
                Single currentSize = System.Convert.ToSingle(mytag[4]) * newy;//�����С
                con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                if (con.Controls.Count > 0)
                {
                    setControls(newx, newy, con);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            X = this.Width;//��ȡ����Ŀ��
            Y = this.Height;//��ȡ����ĸ߶�
            setTag(this);//���÷���

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            float newx = (this.Width) / X; //���������ű���
            float newy = (this.Height) / Y;//����߶����ű���
            setControls(newx, newy, this);//�洰��ı�ؼ���С
        }
    }
}