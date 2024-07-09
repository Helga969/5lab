using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5lab
{
    class Controller
    {
        //Форма авторизации
        View.ViewAuthorization v_auth;
        public Controller(View.ViewAuthorization viewAutor)
        {
            v_auth = viewAutor;
        }
        public async Task btnAuthorization_Click()
        {
            Model.Users us = new Model.Users();
            us.Login = v_auth.login;
            us.Password = v_auth.pass;
            await DataBase.auth(us);
        }
        //форма администратора
        View.ViewUsers v_users;
        public Controller(View.ViewUsers viewUsers)
        {
            v_users = viewUsers;
        }
        public async Task AddUsers_Click()
        {
            Model.Users usr = new Model.Users();
            usr.Login = v_users.Login;
            usr.Password = v_users.Passw;
            await DataBase.AddUsers(usr);
        }
        public async Task DelUsers_Click()
        {
            Model.Users usr = new Model.Users();
            usr.IdUsers = v_users.idUSR;
            await DataBase.DelUsers(usr);
        }
        public async Task ChUsers_Click()
        {
            Model.Users usr = new Model.Users();
            usr.Login = v_users.Login;
            usr.IdUsers = v_users.idUSR;
            usr.Password = v_users.Passw;
            await DataBase.ChUsers(usr);
        }
        //форма заправщика
        View.View_Bowser v_bowser;
        public Controller(View.View_Bowser view_Bowser)
        {
            v_bowser = view_Bowser;
        }
        public async Task AddAuto_Click()
        {
            Model.Auto au = new Model.Auto();
            au.Number = v_bowser.Num;
            await DataBase.AddAuto(au);
        }
        
        public async Task ChAuto_Click()
        {
            Model.Auto au = new Model.Auto();
            au.IdAuto = v_bowser.idAu;
            au.Number = v_bowser.Num;
            await DataBase.ChAuto(au);
        }

        public async Task DelAuto_Click()
        {
            Model.Auto au = new Model.Auto();
            au.IdAuto = v_bowser.idAu;
            await DataBase.DelAuto(au);
        }

        public async Task AddDriver_Click()
        {
            Model.Driver dr = new Model.Driver();
            dr.FIO = v_bowser.fio;
            await DataBase.AddDriver(dr);
        }

        public async Task ChDriver_Click()
        {
            Model.Driver dr = new Model.Driver();
            dr.FIO = v_bowser.fio;
            dr.IdDriver = v_bowser.idDr;
            await DataBase.ChDriver(dr);
        }

        public async Task DelDriver_Click()
        {
            Model.Driver dr = new Model.Driver();
            dr.IdDriver = v_bowser.idDr;
            await DataBase.DelDriver(dr);
        }

        public async Task AddGarage_Click()
        {
            Model.Garage gr = new Model.Garage();
            gr.Address = v_bowser.Addr;
            await DataBase.AddGarage(gr);
        }

        public async Task ChGarage_Click()
        {
            Model.Garage gr = new Model.Garage();
            gr.Address = v_bowser.Addr;
            gr.IdGarage = v_bowser.idGr;
            await DataBase.ChGarage(gr);
        }

        public async Task DelGarage_Click()
        {
            Model.Garage gr = new Model.Garage();
            gr.IdGarage = v_bowser.idGr;
            await DataBase.DelGarage(gr);
        }

        public async Task AddAutobase_Click()
        {
            Model.Autobase ab = new Model.Autobase();
            ab.Name = v_bowser.nm;
            await DataBase.AddAutobase(ab);
        }

        public async Task ChAutobase_Click()
        {
            Model.Autobase ab = new Model.Autobase();
            ab.Name = v_bowser.nm;
            ab.IdAutobase = v_bowser.idaubs;
            await DataBase.ChAutobase(ab);
        }

        public async Task DelAutobase_Click()
        {
            Model.Autobase ab = new Model.Autobase();
            ab.IdAutobase = v_bowser.idaubs;
            await DataBase.DelAutobase(ab);
        }

        public async Task AddStatement_Click()
        {
            Model.Statement st = new Model.Statement();
            st.Date = v_bowser.Date;
            st.Flue = v_bowser.Flue;
            st.Volume = v_bowser.Volume;
            st.Driver = v_bowser.driv;
            st.Autobase = v_bowser.autoba;
            st.Garage = v_bowser.garage;
            st.Auto = v_bowser.auto;
            await DataBase.AddStatement(st);
        }

        public async Task ChStatement_Click()
        {
            Model.Statement st = new Model.Statement();
            st.IdStatement = v_bowser.idSt;
            st.Date = v_bowser.Date;
            st.Flue = v_bowser.Flue;
            st.Volume = v_bowser.Volume;
            st.Driver = v_bowser.driv;
            st.Autobase = v_bowser.autoba;
            st.Garage = v_bowser.garage;
            st.Auto = v_bowser.auto;
            await DataBase.ChStatement(st);
        }

        public async Task DelStatement_Click()
        {
            Model.Statement st = new Model.Statement();
            st.IdStatement = v_bowser.idSt;
            await DataBase.DelStatement(st);
        }
    }
}
