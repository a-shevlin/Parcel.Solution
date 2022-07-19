using System.Collections.Generic;
namespace Parcel.Models
{
  public class ParcelCheck
  {
    public string Length { get; set; }
    public string Width { get; set; }
    public string Height { get; set; }
    public string Volume { get; set; }
    public string Weight { get; set; }
    public string Cost { get; set; }
    private static List<ParcelCheck> _packages = new List<ParcelCheck> {};

    public ParcelCheck()
    {
      _packages.Add(this);
    }

    public static List<ParcelCheck> GetAll()
    {
      return _packages;
    }

      // Parcel newParcel = new Parcel();
      // newParcel.Length = length;

      // newParcel.GetVolume();
    public string GetVolume()
    {
      int _length = int.Parse(Length);
      int _width = int.Parse(Width);
      int _height = int.Parse(Height);
      int _volume = _length * _width * _height;
      Volume = _volume.ToString();
      return Volume;
    }

    public string CostToShip()
    {
      int v = int.Parse(Volume);
      int w = int.Parse(Weight);
      int cost = 0;

          //v = 23  w = 2
      if (v <= 20 && w <= 5 || v >= 20 && w <= 5 || v <= 20 && w >= 5)
      {
        cost = (v + w) * 2;
      }
      else if (v <= 40 && w <= 10 || v >= 40 && w <= 10 || v <= 40 && w >= 10)
      {
        cost = (v + w) * 3;
      }
      else
      {
        cost = (v + w) * 6;
      }
      Cost = cost.ToString();
      return Cost;
    }
  }
}