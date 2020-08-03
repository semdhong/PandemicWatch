﻿using UltraMapper;

namespace Pegasus.Command.Shared.Dto
{
    public static class ObjectExtensions
    {
        private static readonly Mapper _mapper = new Mapper();
        public static T DeepClone<T>(this T original) => (T)_mapper.Map((object)original);
    }
}
