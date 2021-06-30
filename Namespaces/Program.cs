using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Notification=>id, Text, DateTime, FromUser(bu hansi user terefinden bu bildirishin geldiyidir)

//Demeli sistemde 2 teref var User ve Admin
//1.program achilanda user ve ya admin kimi daxil olmasi sorushulur
//2.her ikisi de username(ve ya email) ve password daxil edirler
//3.User yalniz umumi postlara baxa biler ve
//Like ede biler(baxmaq ve like procesini ID esasinda apara bilersiniz)
//Meselen: posta baxish uchun id ni daxil edin ve like uchun
//Id daxil edin
//her defe posta baxildiqca ve ya like edildikce postun baxish sayi ve like sayi artir
//ve her defe de admine bildirish gelir her baxish ve ya like edilende
//(BU SISTEMI DAHA DA TEKMILLESHDIRIB MAIL SISTEMI
//YARADA BILERSINIZ MESELEN 
//her defe notificationlar yaransin hem Admin klasindaki notification elave olunsun hem de mail olaraq admine gonderile biler)

namespace UserNamespace { 
    class User
    {
        public int Id { get; set; }
        public int MyId { get; set; } = 0;
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        User() { Id = ++MyId; }
        User(string name,string surname,int age,string email,string password)
        {
            Id = ++MyId;
            Name = name;
            Surname = surname;
            Age = age;
            Email = email;
            Password = password;
        }

    }
}
namespace PostNamespace { 
    class Post
    {
        public int Id { get; set; }
        public int MyId { get; set; } = 0;
        public string Content { get; set; }
        public DateTime CreationDateTime { get; set; }
        public int LikeCount { get; set; } = 0;
        public int ViewCount { get; set; } = 0;
    }
}
namespace AdminNamespace {
    using User = UserNamespace.User;
    using Post = PostNamespace.Post;
    class Notification
    {
        public int Id { get; set; }
        public int MyId { get; set; } = 0;
        public string Text { get; set; }
        public DateTime Datetime { get; set; }
        public User FromUser { get; set; }


    }
class Admin
    {
        public int ID { get; set; }
        public int MyId { get; set; } = 0;
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Post[] Posts { get; set; }
        public Notification[] Notifications { get; set; }
    }
}
namespace NetworkNamespace { }




namespace Namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
