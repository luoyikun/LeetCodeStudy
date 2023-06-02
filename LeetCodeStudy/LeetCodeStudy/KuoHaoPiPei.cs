using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 给定一个只包括 '('，')'，'{'，'}'，'['，']' 的字符串 s ，判断字符串是否有效。

//有效字符串需满足：

//左括号必须用相同类型的右括号闭合。
//左括号必须以正确的顺序闭合。
 

//来源：力扣（LeetCode）
//链接：https://leetcode-cn.com/problems/valid-parentheses
//著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。

//    方法一：栈
//判断括号的有效性可以使用「栈」这一数据结构来解决。

//我们遍历给定的字符串 ss。当我们遇到一个左括号时，我们会期望在后续的遍历中，有一个相同类型的右括号将其闭合。由于后遇到的左括号要先闭合，因此我们可以将这个左括号放入栈顶。

//当我们遇到一个右括号时，我们需要将一个相同类型的左括号闭合。此时，我们可以取出栈顶的左括号并判断它们是否是相同类型的括号。如果不是相同的类型，或者栈中并没有左括号，那么字符串 ss 无效，返回 \text{False}False。为了快速判断括号的类型，我们可以使用哈希表存储每一种括号。哈希表的键为右括号，值为相同类型的左括号。

//在遍历结束后，如果栈中没有左括号，说明我们将字符串 ss 中的所有左括号闭合，返回 \text{True}True，否则返回 \text{False}False。

//注意到有效字符串的长度一定为偶数，因此如果字符串的长度为奇数，我们可以直接返回 \text{False}False，省去后续的遍历判断过程。

//作者：LeetCode-Solution
//链接：https://leetcode-cn.com/problems/valid-parentheses/solution/you-xiao-de-gua-hao-by-leetcode-solution/
//来源：力扣（LeetCode）
//著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
/// </summary>
namespace LeetCodeStudy
{
    public class KuoHaoPiPei
    {
        Dictionary<char, char> m_dicKuoHao = new Dictionary<char, char>()
        {
            { ']','['},
            {'}' ,'{'},
            { ')','('},
        };

        public bool IsValid(string str)
        {
            bool ret = false;
            if (str.Length % 2 != 0)
            {
                return false;
            }
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (m_dicKuoHao.ContainsValue(c) == true)
                {
                    stack.Push(c);
                }

                if (m_dicKuoHao.ContainsKey(c) == true)
                {
                    if (stack.Count >= 1)
                    {
                        char top = stack.Peek();
                        if (m_dicKuoHao[c] == top)
                        {
                            stack.Pop();
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }

            if (stack.Count == 0)
            {
                return true;
            }
            return ret;
        }

        public void Test()
        {
            Console.WriteLine(IsValid("[{{({{)}}]"));
        }
    }
}
