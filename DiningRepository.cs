using RepoDb;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using DiningVsCodeNew;
using Microsoft.Extensions.Configuration;
using RepoDb.DbHelpers;
using RepoDb.DbSettings;
using RepoDb.Enumerations;
using RepoDb.StatementBuilders;
using DiningVsCodeNew.Models;

namespace DiningVsCodeNew
{
    
    public class UserRepository: BaseRepository<User, SqlConnection>
    {
        
        //Setting cstring=new Setting();
         Setting sett=new Setting();
        public UserRepository(Setting sett) : base(sett.ConString)
        {
            this.sett=sett;
            DbSettingMapper.Add<SqlConnection>(new SqlServerDbSetting(), true);
            DbHelperMapper.Add<SqlConnection>(new SqlServerDbHelper(), true);
            StatementBuilderMapper.Add<SqlConnection>(new SqlServerStatementBuilder(new SqlServerDbSetting()),true);

        }
        public  void insertUser(User us)
        {
            //UserRepository usrrepository = new UserRepository(cstring.ConString);
            this.Insert(us);
        }
        public  void updateUser(User us)
        {
           
            this.Update(us);
        }
        public int deleteUser(User us)
        {
           
            int id = this.Delete<User>(us);
            return id;
        }
        public List<User> GetUsers()
        {  
          
           var users= new List<User>();
           using (var connection = new SqlConnection(sett.ConString))
            {
                users = connection.QueryAll<User>().ToList();
                /* Do the stuffs for the people here */
            }
          return users;
        }
        public User GetUser(int id)
        {  
          
           var user= new User();
           using (var connection = new SqlConnection(sett.ConString))
            {
                
               user = connection.Query<User>(id).FirstOrDefault();
            }
          return user;
        }
        public User GetUser(string username)
        {  
          
           var user= new User();
           using (var connection = new SqlConnection(sett.ConString))
            {
               user = connection.Query<User>(e=>e.userName==username).FirstOrDefault();
            }
          return user;
        }
         
    }
    public class ServedRepository: BaseRepository<Served, SqlConnection>
    {
        
        //Setting cstring=new Setting();
         Setting sett=new Setting();
        public ServedRepository(Setting sett) : base(sett.ConString)
        {
            this.sett=sett;
            DbSettingMapper.Add<SqlConnection>(new SqlServerDbSetting(), true);
            DbHelperMapper.Add<SqlConnection>(new SqlServerDbHelper(), true);
            StatementBuilderMapper.Add<SqlConnection>(new SqlServerStatementBuilder(new SqlServerDbSetting()),true);

        }
        public  void insertServed(Served serv)
        {
            //UserRepository usrrepository = new UserRepository(cstring.ConString);
            this.Insert(serv);
        }
        public  void updateServed(Served serv)
        {
           
            this.Update(serv);
        }
        public int deleteServed(Served serv)
        {
            int id=0;
            using (var connection = new SqlConnection(ConnectionString))
            {
                var deletedRows = connection.Delete<Served>(p => p.Id == serv.Id);
                id=deletedRows;
            }
           
            return id;
        }
        public List<Served> GetServeds()
        {  
          
           var serveds= new List<Served>();
           using (var connection = new SqlConnection(sett.ConString))
            {
                 var sql = "SELECT * FROM [dbo].[Served] Where isserved=0";
                 serveds = connection.ExecuteQuery<Served>(sql).ToList();
                // serveds = connection.QueryAll<Served>(e => e.isServed == 0).ToList();
                foreach (Served sv in serveds)
                {
                    sv.paymentMain=connection.Query<PaymentMain>(sv.paymentMainId).FirstOrDefault();
                }
            }
          return serveds;
        }
         public List<Served> GetServedbyCustomer(int id)
        {  
          
           var serveds= new List<Served>();
           using (var connection = new SqlConnection(sett.ConString))
            {
                 var sql = "SELECT * FROM [dbo].[Served] S inner join paymentmain P on S.paymentmainid=P.id Where isserved=0 and P.enteredby=@id";
                 serveds = connection.ExecuteQuery<Served>(sql,new {id=id}).ToList();
                // serveds = connection.QueryAll<Served>(e => e.isServed == 0).ToList();
                foreach (Served sv in serveds)
                {
                    sv.paymentMain=connection.Query<PaymentMain>(sv.paymentMainId).FirstOrDefault();
                }
            }
          return serveds;
        }
        public Served GetServed(int id)
        {  
          
           var served= new Served();
           using (var connection = new SqlConnection(sett.ConString))
            {
                
               served = connection.Query<Served>(id).FirstOrDefault();
            }
          return served;
        }
        // public Served GetServed(string username)
        // {  
          
        //    var user= new User();
        //    using (var connection = new SqlConnection(sett.ConString))
        //     {
        //        user = connection.Query<User>(e=>e.userName==username).FirstOrDefault();
        //     }
        //   return user;
        // }
         
    }
    public class OnlinePaymentRepository: BaseRepository<OnlinePayment, SqlConnection>
    {
        
        //Setting cstring=new Setting();
         Setting sett=new Setting();
        public OnlinePaymentRepository(Setting sett) : base(sett.ConString)
        {
            this.sett=sett;
            DbSettingMapper.Add<SqlConnection>(new SqlServerDbSetting(), true);
            DbHelperMapper.Add<SqlConnection>(new SqlServerDbHelper(), true);
            StatementBuilderMapper.Add<SqlConnection>(new SqlServerStatementBuilder(new SqlServerDbSetting()),true);

        }
        public  void insertOnlinePayment(OnlinePayment onlinepymt)
        {
            //UserRepository usrrepository = new UserRepository(cstring.ConString);
            this.Insert(onlinepymt);
        }
        public  void updateOnlinePayment(OnlinePayment onlinepymt)
        {
           
            this.Update(onlinepymt);
        }
        public int deleteOnlinePayment(OnlinePayment onlinepymt)
        {
           
            int id = this.Delete<OnlinePayment>(onlinepymt);
            return id;
        }
        public List<OnlinePayment> GetOnlinePayments()
        {  
          
           var onlinepayments= new List<OnlinePayment>();
           using (var connection = new SqlConnection(sett.ConString))
            {
                onlinepayments = connection.QueryAll<OnlinePayment>().ToList();
                /* Do the stuffs for the people here */
            }
          return onlinepayments;
        }
        public OnlinePayment GetOnlinePayment(int id)
        {  
          
           var onlinepayment= new OnlinePayment();
           using (var connection = new SqlConnection(sett.ConString))
            {
                
               onlinepayment = connection.Query<OnlinePayment>(id).FirstOrDefault();
            }
          return onlinepayment;
        }
        // public User GetOnlinePayment(string username)
        // {  
          
        //    var user= new User();
        //    using (var connection = new SqlConnection(sett.ConString))
        //     {
        //        user = connection.Query<User>(e=>e.userName==username).FirstOrDefault();
        //     }
        //   return user;
        // }
         
    }
   
    
    public class CustomerTypeRepository: BaseRepository<CustomerType, SqlConnection>
    {
       
        Setting sett=new Setting();
        public CustomerTypeRepository(Setting sett) : base(sett.ConString)
        {
            this.sett=sett;
            DbSettingMapper.Add<SqlConnection>(new SqlServerDbSetting(), true);
            DbHelperMapper.Add<SqlConnection>(new SqlServerDbHelper(), true);
            StatementBuilderMapper.Add<SqlConnection>(new SqlServerStatementBuilder(new SqlServerDbSetting()),true);
        }
        public  void insertCustomerType(CustomerType CustType)
        {
            
            this.Insert(CustType);
        }
        public  void updateCustomerType(CustomerType CustType)
        {
           
            this.Update(CustType);
        }
        public int deleteCustomerType(CustomerType CustType)
        {
            //CustomerTypeRepository custTypeRepository = new CustomerTypeRepository(cstring);
            int id = this.Delete<CustomerType>(CustType);
            return id;
        }
        public List<CustomerType> GetCustomerTypes()
        {
            
           //var user=new User();
        //  Setting sett=new Setting();
           List<CustomerType> CustomerTypes=new List<CustomerType>();
           using (var connection = new SqlConnection(sett.ConString))
            {
                 CustomerTypes = connection.QueryAll<CustomerType>().ToList();
                /* Do the stuffs for the people here */
            }
          return CustomerTypes;
        }
         
    }
     public class PaymentModeRepository: BaseRepository<PaymentMode, SqlConnection>
    {
       
        Setting sett=new Setting();
        public PaymentModeRepository(Setting sett) : base(sett.ConString)
        {
            this.sett=sett;
            DbSettingMapper.Add<SqlConnection>(new SqlServerDbSetting(), true);
            DbHelperMapper.Add<SqlConnection>(new SqlServerDbHelper(), true);
            StatementBuilderMapper.Add<SqlConnection>(new SqlServerStatementBuilder(new SqlServerDbSetting()),true);
        }
        public  void insertPaymentMode(PaymentMode pymtMode)
        {
            
            this.Insert(pymtMode);
        }
        public  void updatePaymentMode(PaymentMode pymtMode)
        {
           
            this.Update(pymtMode);
        }
        public int deletePaymentMode(PaymentMode pymtMode)
        {
            //CustomerTypeRepository custTypeRepository = new CustomerTypeRepository(cstring);
            int id = this.Delete<PaymentMode>(pymtMode);
            return id;
        }
        public List<PaymentMode> GetPaymentModes()
        {
            
           //var user=new User();
        //  Setting sett=new Setting();
           List<PaymentMode> paymentmodes=new List<PaymentMode>();
           using (var connection = new SqlConnection(sett.ConString))
            {
                 paymentmodes = connection.QueryAll<PaymentMode>().ToList();
                /* Do the stuffs for the people here */
            }
          return paymentmodes;
        }
         
    }
     public class OrderedMealRepository: BaseRepository<OrderedMeal, SqlConnection>
    {
       
        Setting sett=new Setting();
        public OrderedMealRepository(Setting sett) : base(sett.ConString)
        {
            this.sett=sett;
            DbSettingMapper.Add<SqlConnection>(new SqlServerDbSetting(), true);
            DbHelperMapper.Add<SqlConnection>(new SqlServerDbHelper(), true);
            StatementBuilderMapper.Add<SqlConnection>(new SqlServerStatementBuilder(new SqlServerDbSetting()),true);
        }
        public  void insertOrderedMeal(OrderedMeal orderedMeal)
        {
            
            this.Insert(orderedMeal);
        }
        public  void updateOrderedMeal(OrderedMeal orderedMeal)
        {
           
            this.Update(orderedMeal);
        }
        public int deleteOrderedMeal(OrderedMeal orderedMeal)
        {
            //CustomerTypeRepository custTypeRepository = new CustomerTypeRepository(cstring);
            int id = this.Delete<OrderedMeal>(orderedMeal);
            return id;
        }
        public List<OrderedMeal> GetOrderedMeals()
        {
            
           //var user=new User();
        //  Setting sett=new Setting();
           List<OrderedMeal> orderedMeals=new List<OrderedMeal>();
           using (var connection = new SqlConnection(sett.ConString))
            {
                 orderedMeals = connection.QueryAll<OrderedMeal>().ToList();
                /* Do the stuffs for the people here */
            }
          return orderedMeals;
        }
         public List<OrderedMeal> GetOrderedMealsbyCust(User us)
        {
 
           List<OrderedMeal> orderedMeals=new List<OrderedMeal>();
           using (var connection = new SqlConnection(sett.ConString))
            {
                 var sql = "SELECT * FROM [dbo].[orderedmeal]  Where submitted=0 and enteredby=@enteredby";
                 orderedMeals = connection.ExecuteQuery<OrderedMeal>(sql,new {Enteredby=us.id}).ToList();
                // serveds = connection.QueryAll<Served>(e => e.isServed == 0).ToList();
                foreach (OrderedMeal ord in orderedMeals)
                {
                    ord.menu=connection.Query<Menu>(ord.MealId).FirstOrDefault();
                }
            }
          return orderedMeals;
        }
         
    }

     public class MenuRepository: BaseRepository<Menu, SqlConnection>
    {
        Setting sett=new Setting();
        public MenuRepository(Setting sett) : base(sett.ConString)
        {
            this.sett=sett;
            DbSettingMapper.Add<SqlConnection>(new SqlServerDbSetting(), true);
            DbHelperMapper.Add<SqlConnection>(new SqlServerDbHelper(), true);
            StatementBuilderMapper.Add<SqlConnection>(new SqlServerStatementBuilder(new SqlServerDbSetting()),true);
        }
        public  void insertMenu(Menu menu)
        {
           // MenuRepository menuRepository = new MenuRepository(constringmenu);
            this.Insert(menu);
        }
        public  void updateMenu(Menu menu)
        {
            //MenuRepository menuRepository = new MenuRepository(constringmenu);
            this.Update(menu);
        }
        public int deleteMenu(Menu menu)
        {
            //MenuRepository menuRepository = new MenuRepository(constringmenu);
            int id = this.Delete<Menu>(menu);
            return id;
        }
        public List<Menu> GetMenus()
        {
            
        //    Setting sett=new Setting();
           List<Menu> menus=new List<Menu>();
           using (var connection = new SqlConnection(sett.ConString))
            {
                menus = connection.ExecuteQuery<Menu>("[dbo].[usp_getmenus]",
                commandType: System.Data.CommandType.StoredProcedure).ToList(); 
                 //menus = connection.QueryAll<Menu>().ToList();
                /* Do the stuffs for the people here */
            }
          return menus;
        }

         public Menu GetMenu(int id)
        {  
          
           var menu= new Menu();
           using (var connection = new SqlConnection(sett.ConString))
            {
                
               menu = connection.Query<Menu>(id).FirstOrDefault();
            }
          return menu;
        }
         
    }
     public class MenuCategoryRepository: BaseRepository<MenuCategory, SqlConnection>
    {
       Setting sett=new Setting();
        public MenuCategoryRepository(Setting sett) : base(sett.ConString)
        {
             this.sett=sett;
            DbSettingMapper.Add<SqlConnection>(new SqlServerDbSetting(), true);
            DbHelperMapper.Add<SqlConnection>(new SqlServerDbHelper(), true);
            StatementBuilderMapper.Add<SqlConnection>(new SqlServerStatementBuilder(new SqlServerDbSetting()),true);
        }
        public  void insertMenuCat(MenuCategory menuCat)
        {
            //MenuCategoryRepository menuCatRepository = new MenuCategoryRepository(constringmenucat);
            this.Insert(menuCat);
        }
        public  void updateMenuCat(MenuCategory menuCat)
        {
            //MenuCategoryRepository menuCatRepository = new MenuCategoryRepository(constringmenucat);
            this.Update(menuCat);
        }
        public int deleteMenuCat(MenuCategory menuCat)
        {
           // MenuCategoryRepository menuCatRepository = new MenuCategoryRepository(constringmenucat);
            int id = this.Delete<MenuCategory>(menuCat);
            return id;
        }
        public List<MenuCategory> GetMenuCategories()
        {
            
          Setting sett=new Setting();
           List<MenuCategory> menuCategories=new List<MenuCategory>();
           using (var connection = new SqlConnection(sett.ConString))
            {
                 menuCategories = connection.QueryAll<MenuCategory>().ToList();
                /* Do the stuffs for the people here */
            }
          return menuCategories;
        }
         
    }

     public class PaymentDetailsRepository: BaseRepository<PaymentDetails, SqlConnection>
    {
       
       Setting sett=new Setting();
        public PaymentDetailsRepository(Setting sett) : base(sett.ConString)
        {
                this.sett=sett;
            DbSettingMapper.Add<SqlConnection>(new SqlServerDbSetting(), true);
            DbHelperMapper.Add<SqlConnection>(new SqlServerDbHelper(), true);
            StatementBuilderMapper.Add<SqlConnection>(new SqlServerStatementBuilder(new SqlServerDbSetting()),true);
        }
        public  void insertPaymentDetails(PaymentDetails pymtDetails)
        {
            //PaymentDetailsRepository pymtdetailsRepository = new PaymentDetailsRepository(constringPymtDet);
            this.Insert(pymtDetails);
        }
        public  void updatePaymentDetails(PaymentDetails pymtDetails)
        {
            //PaymentDetailsRepository pymtDetRepository = new PaymentDetailsRepository(constringPymtDet);
            this.Update(pymtDetails);
        }
        public int deletePymtDetails(PaymentDetails pymtDetails)
        {
            //PaymentDetailsRepository pymtDetRepository = new PaymentDetailsRepository(constringPymtDet);
            int id = this.Delete<PaymentDetails>(pymtDetails);
            return id;
        }
        public List<PaymentDetails> GetPymtDetails()
        {
            
          List<PaymentDetails> pymtDetails=new List<PaymentDetails>();
           using (var connection = new SqlConnection(sett.ConString))
            {
                pymtDetails = connection.ExecuteQuery<PaymentDetails>("[dbo].[usp_getpaymentdetails]",
                commandType: System.Data.CommandType.StoredProcedure).ToList(); 
                /* Do the stuffs for the people here */
            }
          return pymtDetails;
         
        }
           public List<PaymentDetails> GetPymtDetails(int userid)
        {
            
           //var user=new User();
           List<PaymentDetails> paymentDetailss=new List<PaymentDetails>();
           using (var connection = new SqlConnection(sett.ConString))
            {
                 paymentDetailss = connection.ExecuteQuery<PaymentDetails>("[dbo].[usp_getpaymentdetailsbyuser]", 
               new { userID = userid}, commandType: System.Data.CommandType.StoredProcedure).ToList();
                /* Do the stuffs for the people here */
            }
          return paymentDetailss;
        }
         
    }
     public class PaymentMainRepository: BaseRepository<PaymentMain, SqlConnection>
    {
        Setting sett=new Setting();
        public PaymentMainRepository(Setting sett) : base(sett.ConString)
        {
                this.sett=sett;
            DbSettingMapper.Add<SqlConnection>(new SqlServerDbSetting(), true);
            DbHelperMapper.Add<SqlConnection>(new SqlServerDbHelper(), true);
            StatementBuilderMapper.Add<SqlConnection>(new SqlServerStatementBuilder(new SqlServerDbSetting()),true);
        }
        public  void insertPaymentMain(PaymentMain pymtMain)
        {
            //PaymentMainRepository pymtMainRepository = new PaymentMainRepository(constringPymtMain);
            this.Insert(pymtMain);
        }
        public  void updatePaymentMain(PaymentMain pymtMain)
        {
            //PaymentMainRepository pymtMainRepository = new PaymentMainRepository(constringPymtMain);
            this.Update(pymtMain);
        }
        public int deletePymtMain(PaymentMain pymtMain)
        {
            //PaymentMainRepository pymtMainRepository = new PaymentMainRepository(constringPymtMain);
           
            using (var connection = new SqlConnection(sett.ConString))
            {
                var deletedrows = connection.Delete<PaymentMain>(pymtMain.Id);
                 return deletedrows;
            }
        }
        public List<PaymentMain> GetPymtMains()
        {
            
           //var user=new User();
           List<PaymentMain> pymtMains=new List<PaymentMain>();
           using (var connection = new SqlConnection(sett.ConString))
            {
                 pymtMains = connection.QueryAll<PaymentMain>().ToList();
                /* Do the stuffs for the people here */
            }
          return pymtMains;
        }
         public List<PaymentByCust> GetPaidPymts()
        {
            
           //var user=new User();
           List<PaymentByCust> paidpymts=new List<PaymentByCust>();
           using (var connection = new SqlConnection(sett.ConString))
            {
                 paidpymts = connection.ExecuteQuery<PaymentByCust>("[dbo].[usp_getPymtByCust]",
                commandType: System.Data.CommandType.StoredProcedure).ToList();
            }
          return paidpymts;
        }

          public List<PaymentMain> GetPaidPymtsByCust(string enteredby)
        {
            
           List<PaymentMain> paidpymts=new List<PaymentMain>();
           using (var connection = new SqlConnection(sett.ConString))
            {
                 paidpymts = connection.ExecuteQuery<PaymentMain>("[dbo].[usp_getPaidPymtByCust]",
               new{enteredby=enteredby}, commandType: System.Data.CommandType.StoredProcedure).ToList();
            }
          return paidpymts;
        }
       

         
    }
     public class VoucherRepository: BaseRepository<Voucher, SqlConnection>
    {
        Setting sett=new Setting();
        public VoucherRepository(Setting sett) : base(sett.ConString)
        {
            this.sett=sett;
            DbSettingMapper.Add<SqlConnection>(new SqlServerDbSetting(), true);
            DbHelperMapper.Add<SqlConnection>(new SqlServerDbHelper(), true);
            StatementBuilderMapper.Add<SqlConnection>(new SqlServerStatementBuilder(new SqlServerDbSetting()),true);
        }
        public  void insertVoucher(Voucher voucher)
        {
            //VoucherRepository voucherRepository = new VoucherRepository(constringVoucher);
            this.Insert(voucher);
        }
        public  void updateVoucher(Voucher voucher)
        {
            //VoucherRepository voucherRepository = new VoucherRepository(constringVoucher);
            this.Update(voucher);
        }
        public int deleteVoucher(Voucher voucher)
        {
            //VoucherRepository voucherRepository = new VoucherRepository(constringVoucher);
            int id = this.Delete<Voucher>(voucher);
            return id;
        }
        public List<Voucher> GetPymtVouchers()
        {
            
           //var user=new User();
           List<Voucher> vouchers=new List<Voucher>();
           using (var connection = new SqlConnection(sett.ConString))
            {
                 vouchers = connection.ExecuteQuery<Voucher>("[dbo].[usp_getvoucherdetails]",
                commandType: System.Data.CommandType.StoredProcedure).ToList();
                /* Do the stuffs for the people here */
            }
          return vouchers;
        }

        public List<Voucher> GetVouchers(int custTypeid)
        {  
          
           List<Voucher> vouchers=new List<Voucher>();
           using (var connection = new SqlConnection(sett.ConString))
            {
               vouchers = connection.Query<Voucher>(e=>e.Custtypeid==custTypeid).ToList();
            //    (e=>e.Custtypeid==custTypeid).ToList();
            }
          return vouchers;
        }

       
         
    }

}