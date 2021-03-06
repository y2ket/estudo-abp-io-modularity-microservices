﻿using Volo.Abp.Reflection;

namespace AbpMicroRabbit.Banking.Application.Contracts.Permissions
{
    public class BankingPermissions
    {
        public const string GroupName = "Banking";

        public static class Accounts
        {
            public const string Default = GroupName + ".Account";
            public const string Delete = Default + ".Delete";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Transfer = Default + ".Transfer";
        }

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(BankingPermissions));
        }
    }
}
