﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
   public   class Lists:IEnumerable<UserInfo>
   {
         
       public static IEnumerable<UserInfo> GetUserInfos()
       {
           var list = new List<UserInfo>()
           {
               new UserInfo(){Name = "aaa",Age = 19},
               new UserInfo(){Name = "bbb",Age = 22},
               new UserInfo(){Name = "ccc",Age = 32}
           };
           return list; 

       }

       private UserInfo[] list = null;

       public Lists()
       {
           GetUserInfoArrs();
       }
       public   UserInfo[] GetUserInfoArrs()
       {
        
             list = new  UserInfo[]
           {
               new UserInfo(){Name = "aaa",Age = 19},
               new UserInfo(){Name = "bbb",Age = 22},
               new UserInfo(){Name = "ccc",Age = 32}
           };
           return list;

       }


       public IEnumerator<UserInfo> GetEnumerator()
       {
           return new UserEnumerator(list);
       }

       IEnumerator IEnumerable.GetEnumerator()
       {
           return new UserEnumerator(list);
       }
   }

    public class UserEnumerator : IEnumerator<UserInfo>
    {

        public UserInfo[] User { get; set; }

        public UserEnumerator(UserInfo[] per)
        {
            this.User = per;
        }
        public void Dispose()
        {
            
        }
        int position = -1;
        public bool MoveNext()
        {
            position++;
            return position < User.Length;
        }

        public void Reset()
        {
              position = -1;
        }

        public UserInfo Current {    get
            {
                try
                {
                    return User[position];
                }
                catch (IndexOutOfRangeException ex)
                {
                    throw new InvalidOperationException();
                }
            } private set{} }

        object IEnumerator.Current
        {
            get
            {
                try
                {
                    return User[position];
                }
                catch (IndexOutOfRangeException ex)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }


    public class UserInfo
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}