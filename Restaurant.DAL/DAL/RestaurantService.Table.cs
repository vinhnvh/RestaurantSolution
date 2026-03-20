public partial class RestaurantService{
    public List<Table> GetTables(){
        return tableDAL.GetTables();
    }
