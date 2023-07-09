namespace praktika2023
{
    public class Line    
    {
        public double x_0;
        public double y_0;
        public double z_0;
        public double l;
        public double m;
        public double n;

        public Line(double x_0, double y_0, double z_0, double l, double m, double n)
        {
            if (l != 0 && m != 0 && n != 0)
            {
                this.x_0 = x_0;
                this.y_0 = y_0;
                this.z_0 = z_0;
                this.l = l;
                this.m = m;
                this.n = n;
            }
            else
            {
                MessageBox.Show("Не удалось создать прямую", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
