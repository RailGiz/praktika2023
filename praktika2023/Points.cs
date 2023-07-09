namespace praktika2023
{
    public class Points
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Points(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double DistanceTo(Points A)
        {
            return Math.Sqrt(Math.Pow(X - A.X, 2) + Math.Pow(Y - A.Y, 2) + Math.Pow(Z - A.Z, 2));
        }

        public double DistanceToLine(Line L)
        {
            double cp_x = (Y - L.y_0) * L.n - (Z - L.z_0) * L.m;
            double cp_y = -((X - L.x_0) * L.n - (Z - L.z_0) * L.l);
            double cp_z = (X - L.x_0) * L.m - (Y - L.y_0) * L.l;
            double cp = Math.Sqrt(Math.Pow(cp_x, 2) + Math.Pow(cp_y, 2) + Math.Pow(cp_z, 2));
            return Math.Round(cp / Math.Sqrt(Math.Pow(L.l, 2) + Math.Pow(L.m, 2) + Math.Pow(L.n, 2)), 2);
        }

        public double TriangleSquare(Points A, Points B)
        {
            double a = DistanceTo(A);
            double b = DistanceTo(B);
            double c = B.DistanceTo(A);
            if (IsValidTriangle(a, b, c))
            {
                double p = (a + b + c) * 0.5;
                return Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 2);
            }
            else
            {
                ShowErrorMessage("Невозможно построить треугольник. Пожалуйста, измените значения!");
                return 0;
            }
        }

        private bool IsValidTriangle(double a, double b, double c)
        {
            return (a + b > c) && (b + c > a) && (c + a > b);
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
