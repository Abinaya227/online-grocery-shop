using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class sqlconnection
{
    private string constr;

    public sqlconnection(string constr)
    {
        // TODO: Complete member initialization
        this.constr = constr;
    }

    public void Close()
    {
        throw new NotImplementedException();
    }
}
