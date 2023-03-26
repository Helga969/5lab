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
        public void btnAuthorization_Click()
        {
            Model.Users us = new Model.Users();
            us.Login = v_auth.login;
            us.Password = v_auth.pass;
            DataBase.auth(us);
        }
        //форма администратора
        View.ViewUsers v_users;
        public Controller(View.ViewUsers viewUsers)
        {
            v_users = viewUsers;
        }
        public void AddUsers_Click()
        {
            Model.Users usr = new Model.Users();
            usr.Login = v_users.Login;
            usr.Password = v_users.Passw;
            DataBase.AddUsers(usr);
        }
        public void DelUsers_Click()
        {
            Model.Users usr = new Model.Users();
            usr.IdUsers = v_users.idUSR;
            DataBase.DelUsers(usr);
        }
        public void ChUsers_Click()
        {
            Model.Users usr = new Model.Users();
            usr.Login = v_users.Login;
            usr.IdUsers = v_users.idUSR;
            usr.Password = v_users.Passw;
            DataBase.ChUsers(usr);
        }
        //форма заправщика
        View.View_Bowser v_bowser;
        public Controller(View.View_Bowser view_Bowser)
        {
            v_bowser = view_Bowser;
        }
        public void AddAuto_Click()
        {
            Model.Auto au = new Model.Auto();
            au.Number = v_bowser.Num;
            DataBase.AddAuto(au);
        }
        
        public void ChAuto_Click()
        {
            Model.Auto au = new Model.Auto();
            au.IdAuto = v_bowser.idAu;
            au.Number = v_bowser.Num;
            DataBase.ChAuto(au);
        }

        public void DelAuto_Click()
        {
            Model.Auto au = new Model.Auto();
            au.IdAuto = v_bowser.idAu;
            DataBase.DelAuto(au);
        }

        public void AddDriver_Click()
        {
            Model.Driver dr = new Model.Driver();
            dr.FIO = v_bowser.fio;
            DataBase.AddDriver(dr);
        }

        public void ChDriver_Click()
        {
            Model.Driver dr = new Model.Driver();
            dr.FIO = v_bowser.fio;
            dr.IdDriver = v_bowser.idDr;
            DataBase.ChDriver(dr);
        }

        public void DelDriver_Click()
        {
            Model.Driver dr = new Model.Driver();
            dr.IdDriver = v_bowser.idDr;
            DataBase.DelDriver(dr);
        }

        public void AddGarage_Click()
        {
            Model.Garage gr = new Model.Garage();
            gr.Address = v_bowser.Addr;
            DataBase.AddGarage(gr);
        }

        public void ChGarage_Click()
        {
            Model.Garage gr = new Model.Garage();
            gr.Address = v_bowser.Addr;
            gr.IdGarage = v_bowser.idGr;
            DataBase.ChGarage(gr);
        }

        public void DelGarage_Click()
        {
            Model.Garage gr = new Model.Garage();
            gr.IdGarage = v_bowser.idGr;
            DataBase.DelGarage(gr);
        }

        public void AddAutobase_Click()
        {
            Model.Autobase ab = new Model.Autobase();
            ab.Name = v_bowser.nm;
            DataBase.AddAutobase(ab);
        }

        public void ChAutobase_Click()
        {
            Model.Autobase ab = new Model.Autobase();
            ab.Name = v_bowser.nm;
            ab.IdAutobase = v_bowser.idaubs;
            DataBase.ChAutobase(ab);
        }

        public void DelAutobase_Click()
        {
            Model.Autobase ab = new Model.Autobase();
            ab.IdAutobase = v_bowser.idaubs;
            DataBase.DelAutobase(ab);
        }

        public void AddStatement_Click()
        {
            Model.Statement st = new Model.Statement();
            st.Date = v_bowser.Date;
            st.Flue = v_bowser.Flue;
            st.Volume = v_bowser.Volume;
            st.Driver = v_bowser.driv;
            st.Autobase = v_bowser.autoba;
            st.Garage = v_bowser.garage;
            st.Auto = v_bowser.auto;
            DataBase.AddStatement(st);
        }

        public void ChStatement_Click()
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
            DataBase.ChStatement(st);
        }

        public void DelStatement_Click()
        {
            Model.Statement st = new Model.Statement();
            st.IdStatement = v_bowser.idSt;
            DataBase.DelStatement(st);
        }
    }
}
