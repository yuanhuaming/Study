using System;
using System.Collections;
using System.Collections.Generic;

namespace Common
{
   public   class Lists:IEnumerable<UserInfo>
   {
         
       public static IEnumerable<UserInfo> GetUserInfos()
       {
           var list = new List<UserInfo>()
           {
               new UserInfo(){Name = "aaa",Age = 19},
               new UserInfo(){Name = "bbb",Age = 22},
               new UserInfo(){Name = "eee",Age = 22},
               new UserInfo(){Name = "fff",Age = 11},
               new UserInfo(){Name = "ggg",Age = 53},
               new UserInfo(){Name = "rrr",Age = 12},
               new UserInfo(){Name = "ppp",Age = 17},
               new UserInfo(){Name = "zzz",Age = 22},
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

    [Serializable]
    public class UserInfo
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
