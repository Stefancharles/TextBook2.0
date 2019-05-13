using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{ 
    public static class ObjectData
    {
        public static IEnumerable<Book> Books
        {
            get
            {
                var data = new List<Book>()
                {
                    new Book{ Id=1, Title="原子核物理", Author="卢希庭", Press="原子能出版社", Isbn="9787502221881", Price=48},
                    new Book{ Id=2, Title="ASP.NET MVC框架揭秘", Author="蒋金楠", Press="电子工业出版社", Isbn="9787121190490", Price=89},
                    new Book{ Id=3, Title="Microsoft.Silverlight.5.Data.and.Services.Cookbook", Author="Gill Cleeren, Kevin Dockx", Press="Packt", Isbn="9781849683500", Price=53.99},
                    new Book{ Id=4, Title="探索式软件测试", Author="James A.Whittaker", Press="清华大学出版社", Isbn="9787302223849", Price=35},
                    new Book{ Id=5, Title="软件测试的艺术", Author="Glenford J. Myers, Tom Badgett, Corey Sandler", Press="机械工业出版社", Isbn="9787111376606", Price=39},
                    new Book{ Id=6, Title="软件测试实用教程---方法与实践", Author="武剑洁", Press="电子工业出版社", Isbn="9787121186783", Price=39},
                    new Book{ Id=7, Title="软件测试方法和技术", Author="朱少民", Press="清华大小出版社", Isbn="9787302225836", Price=39.5},
                    new Book{ Id=8, Title="软件测试技术", Author="佟伟光", Press="人民邮电出版社", Isbn="9787115223883", Price=32},
                    new Book{ Id=9, Title="实用软件工程", Author="赵池龙", Press="电子工业出版社", Isbn="9787121121050", Price=27},
                    new Book{ Id=10, Title="软件无线电原理与应用", Author="楼才义", Press="电子工业出版社", Isbn="9787121236785", Price=59},
                    new Book{ Id=11, Title="软件设计与体系结构", Author="齐治昌", Press="高等教育出版社", Isbn="9787040284089", Price=27},
                    new Book{ Id=12, Title="软件设计与体系结构（第2版）", Author="齐治昌", Press="高等教育出版社", Isbn="9787040286308", Price=42},
                    new Book{ Id=13, Title="软件工程一般理论、方法与实践", Author="孙家亍，刘强", Press="高等教育出版社", Isbn="9787040163087", Price=29},
                    new Book{ Id=14, Title="软件项目管理案例教程", Author="韩万江", Press="机械工业出版社", Isbn="9787111501633", Price=49},
                    new Book{ Id=15, Title="设计模式：可复用面向对象软件的基础", Author="Erich Gamma", Press="机械工业出版社", Isbn="9787111075752", Price=35},
                    new Book{ Id=16, Title="嵌入式软件开发精解", Author="何小庆", Press="机械工业出版社", Isbn="9787111449522", Price=79},
                    new Book{ Id=17, Title="人机交互 软件工程视角", Author="骆斌", Press="机械工业出版社", Isbn="9787111407478", Price=39},
                    new Book{ Id=18, Title="软件设计与体系结构", Author="周华", Press="科学出版社", Isbn="9787030344298", Price=82},
                    new Book{ Id=19, Title="软件工程导论（第6版）", Author="张海藩", Press="清华大学出版社", Isbn="9787302330981", Price=39.5},
                    new Book{ Id=20, Title="软件构件技术", Author="王玲", Press="清华大学出版社", Isbn="9787512103849", Price=33},
                    new Book{ Id=21, Title="软件体系结构", Author="张友生", Press="清华大学出版社", Isbn="9787302133162", Price=30},
                };
                return data;
            }
            set
            {
            }
        }

    }
}
