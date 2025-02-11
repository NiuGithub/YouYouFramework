using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YouYouFramework
{
    /// <summary>
    /// int变量
    /// </summary>
    public class VarInt : Variable<int>
    {
        /// <summary>
        /// 分配一个对象
        /// </summary>
        /// <returns></returns>
        public static VarInt Alloc()
        {
            VarInt var = GameEntry.Pool.ClassObjectPool.Dequeue<VarInt>();
            var.Value = 0;
            var.Retain();
            return var;
        }

        /// <summary>
        /// 分配一个对象
        /// </summary>
        /// <param name="value">初始值</param>
        /// <returns></returns>
        public static VarInt Alloc(int value)
        {
            VarInt var = Alloc();
            var.Value = value;
            return var;
        }

        /// <summary>
        /// VarInt -> int
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator int(VarInt value)
        {
            return value.Value;
        }
    }
}