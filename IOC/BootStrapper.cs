﻿using Data.UnitOfWork;
using SimpleInjector;

namespace IOC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            // Lifestyle.Transient => Uma instancia para cada solicitacao;
            // Lifestyle.Singleton => Uma instancia unica para a classe
            // Lifestyle.Scoped => Uma instancia unica para o request

            // Infra
            container.Register(typeof(IUnitOfWork<>), typeof(UnitOfWork<>), Lifestyle.Scoped);
        }
    }
}