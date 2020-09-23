namespace age_of_villagers
{
    interface INation
{
        public void paint_house(MouseEventArgs e, Graphics g, Pen p);
        public void paint_tree(MouseEventArgs e, Graphics g, Pen p);
        public void paint_waterSource(MouseEventArgs e, Graphics g, Pen p);

    }
}