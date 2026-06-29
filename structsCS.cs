using System;

// Define your Point struct here
public struct Point
{
    // Add X and Y fields
    public int x;
    public int y;
}

public class Solution
{
    public static string DescribePoint(int x, int y)
    {
        // Create a Point with the given x and y values
        // Return a string in format: "Point(X, Y)"
        Point p1;
        p1.x = x;
        p1.y = y;

        // also we can use 
        // Point p2 = new Point();
        return $"Point({p1.x}, {p1.y})";
    }
}