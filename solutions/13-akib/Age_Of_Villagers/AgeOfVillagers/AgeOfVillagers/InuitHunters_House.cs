namespace AgeOfVillagers
{
    internal class InuitHunters_House : I_Shape
    {
        private string draw = "";

        public string Draw(int x, int y)
        {
            Half_Circle ihh_circle = new Half_Circle(x, y, 8);
            Half_Circle ihh2_circle = new Half_Circle(x, y, 3);

            draw = draw + ihh_circle.Draw_Shape();
            draw = draw + ihh2_circle.Draw_Shape();

            return draw;
        }
    }
}
