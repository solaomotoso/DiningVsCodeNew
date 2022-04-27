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
           Setting sett=new Setting();
           List<CustomerType> CustomerTypes=new List<CustomerType>();
           using (var connection = new SqlConnection(sett.ConString))
            {
                 CustomerTypes = connection.QueryAll<CustomerType>().ToList();
                /* Do the stuffs for the people here */
            }
          return CustomerTypes;
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
            
           Setting sett=new Setting();
           List<Menu> menus=new List<Menu>();
           using (var connection = new SqlConnection(sett.ConString))
            {
                 menus = connection.QueryAll<Menu>().ToList();
                /* Do the stuffs for the people here */
            }
          return menus;
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
        public List<PaymentDetails> GetPymtDetCategories()
        {
            
          List<PaymentDetails> pymtDetails=new List<PaymentDetails>();
           using (var connection = new SqlConnection(sett.ConString))
            {
             
                pymtDetails = connection.QueryAll<PaymentDetails>().ToList();
                /* Do the stuffs for the people here */
            }
          return pymtDetails;
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
            int id = this.Delete<PaymentMain>(pymtMain);
            return id;
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
                 vouchers = connection.QueryAll<Voucher>().ToList();
                /* Do the stuffs for the people here */
            }
          return vouchers;
        }
         
    }

}