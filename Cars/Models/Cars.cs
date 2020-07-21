using System;
using System.Collections.Generic;

namespace Cars.Models {
  public class Car
  {
    private string _makeModel;
    private int _price;
    private int _miles;

    public string MakeModel{ get; set;}
    public int Price { get; set;}
    public int Miles { get; set;}

    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
    }

    public static string MakeSound(string sound)
    {
      return "Our cars sound like " + sound;
    }

    public string GetMakeModel()
    {
      return _makeModel;
    }

    public int GetPrice()
    {
      return _price;
    }

    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }

    public int GetMiles()
    {
      return _miles;
    }
    public bool WorthBuying(int maxPrice)
    {
      return (_price < maxPrice); //will return true or false
    }
  }
}

