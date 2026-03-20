using System;
using System.Collections.Generic;

namespace Restaurant.Services{
  public partial class RestaurantService{
    private TableDAL tableDAL;


    public RestaurantService(){
      tableDAL = new TableDAL();
    }
  }
}
{
