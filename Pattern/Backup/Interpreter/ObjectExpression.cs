using System;
using System.Collections.Generic;
using System.Text;

using System.Text.RegularExpressions;

namespace Pattern.Interpreter
{
    /// <summary>
    /// �ն˹�ʽ��TerminalExpression�������������ص�
    /// </summary>
    public class ObjectExpression : AbstractExpression
    {
        /// <summary>
        /// ������������ȡ��Ҫ���͵Ĵ�
        /// </summary>
        /// <param name="source">source</param>
        /// <returns></returns>
        public override string GetWord(string source)
        {
            MatchCollection mc;
            Regex r = new Regex(@"\[(.*)\]");
            mc = r.Matches(source);

            return mc[0].Groups[1].Value;
        }

        /// <summary>
        /// ��ȡ�������ص��ֵ�
        /// </summary>
        /// <returns></returns>
        public override Dictionary<string, string> GetDictionary()
        {
            Dictionary<string, string> d = new Dictionary<string, string>();

            d.Add("��Ϣ", "Message");

            return d;
        }
    }
}