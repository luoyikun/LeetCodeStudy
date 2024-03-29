﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 给定一个非空整数数组，除了某个元素只出现一次以外，其余每个元素均出现两次。找出那个只出现了一次的元素。

//说明：

//你的算法应该具有线性时间复杂度。 你可以不使用额外空间来实现吗？

//示例 1:

//输入: [2,2,1]
//输出: 1
//示例 2:

//输入: [4,1,2,1,2]
//输出: 4

//来源：力扣（LeetCode）
//链接：https://leetcode-cn.com/problems/single-number
//著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。

//    答案是使用位运算。对于这道题，可使用异或运算 \oplus⊕。异或运算有以下三个性质。

//任何数和 00 做异或运算，结果仍然是原来的数，即 a \oplus 0=aa⊕0=a。
//任何数和其自身做异或运算，结果是 00，即 a \oplus a = 0a⊕a=0。
//异或运算满足交换律和结合律，即 a \oplus b \oplus a = b \oplus a \oplus a = b \oplus(a \oplus a)=b \oplus0=ba⊕b⊕a=b⊕a⊕a=b⊕(a⊕a)=b⊕0=b。

//作者：LeetCode-Solution
//链接：https://leetcode-cn.com/problems/single-number/solution/zhi-chu-xian-yi-ci-de-shu-zi-by-leetcode-solution/
//来源：力扣（LeetCode）
//著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
/// </summary>
namespace LeetCodeStudy
{
    class OnlyOnceNumInList
    {
        public int SingleNumber(int[] nums)
        {
            int ret = 0;
            foreach (int e in nums) ret ^= e;
            return ret;
        }

    }
}
