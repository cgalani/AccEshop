using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccEshop.Models;

//pio sosti seira grammena , prwta to ID meta to Name , etc. Mia sinoxi na iparxi
public class Product
{
    public decimal Price {  get; set; }
    public string Name {  get; set; } = string.Empty;
    public string ? Description { get; set; } // (?) auto simainei oti to dhlwneis oti einai Null 
    public string Id { get; set; }= Guid.NewGuid().ToString();

    public DateTime ProductionTimeStamp { get; set; }




}
