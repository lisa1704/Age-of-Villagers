using AgeOfVillagers;

internal class Half_Circle
{
    private int x, y, radius;
    public Half_Circle(int x, int y, int radius)
    {
        this.x = x;
        this.y = y;
        this.radius = radius;
    }
    public string Draw_Shape()
    {
        Arc arc_half_circle = new Arc(x - radius, y - radius, 2 * radius, 2 * radius, 0, 180);

        arc_half_circle.Draw_Shape();
        return "Drawing a Half Circle...";
    }
}