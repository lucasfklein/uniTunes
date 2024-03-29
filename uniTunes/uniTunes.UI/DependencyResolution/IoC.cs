// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IoC.cs" company="Web Advanced">
// Copyright 2012 Web Advanced (www.webadvanced.com)
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0

// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using StructureMap;
using StructureMap.Graph;
using StructureMap.Web;
using StructureMap.Web.Pipeline;
using uniTunes.Data.Infrastructure;
using uniTunes.Data.Repositories;
using uniTunes.Services;
using uniTunes.Services.Contracts;

namespace uniTunes.UI.DependencyResolution
{
    public static class IoC
    {
        public static IContainer Initialize()
        {
            ObjectFactory.Initialize(x =>
            {
                x.Scan(scan =>
                        {
                            scan.TheCallingAssembly();
                            scan.WithDefaultConventions();
                        });

                x.For<IAuthService>().Use<AuthService>();
                x.For<ICreditService>().Use<CreditService>();
                x.For<IMediaService>().Use<MediaService>();

                x.For<IAcademicRepository>().Use<AcademicRepository>();
                x.For<ICreditRepository>().Use<CreditRepository>();
                x.For<IMediaRepository>().Use<MediaRepository>();

                x.For<IDatabaseFactory>().Use<DatabaseFactory>();
                x.For<IUnitOfWork>().Use<UnitOfWork>();

            });
            return ObjectFactory.Container;
        }
    }
}