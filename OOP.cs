using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class OOP
{
    /*
     // Read-write property
public string Name { get; set; }

// Read-only from outside, settable inside
public int Age { get; private set; }

// Read-only (must be set in constructor)
public string Id { get; }
     
     */

    // Backing fields
    private string _name;

    // Auto-Property
    private string _status { get; set; }

    public OOP(string name) {
        _name = name;
    }
    // Backing fields
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public void Run()
    {

    }
}
