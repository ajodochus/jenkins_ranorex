﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace jenkins_ranorex
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the jenkins_ranorexRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
    [RepositoryFolder("386d29ac-4268-401a-9efb-9c4ac73d2c39")]
    public partial class jenkins_ranorexRepository : RepoGenBaseFolder
    {
        static jenkins_ranorexRepository instance = new jenkins_ranorexRepository();
        jenkins_ranorexRepositoryFolders.MainWindowAppFolder _mainwindow;

        /// <summary>
        /// Gets the singleton class instance representing the jenkins_ranorexRepository element repository.
        /// </summary>
        [RepositoryFolder("386d29ac-4268-401a-9efb-9c4ac73d2c39")]
        public static jenkins_ranorexRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public jenkins_ranorexRepository() 
            : base("jenkins_ranorexRepository", "/", null, 0, false, "386d29ac-4268-401a-9efb-9c4ac73d2c39", ".\\RepositoryImages\\jenkins_ranorexRepository386d29ac.rximgres")
        {
            _mainwindow = new jenkins_ranorexRepositoryFolders.MainWindowAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("386d29ac-4268-401a-9efb-9c4ac73d2c39")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The MainWindow folder.
        /// </summary>
        [RepositoryFolder("18240b7c-7140-41f2-9d2a-e8b9c0b2c19d")]
        public virtual jenkins_ranorexRepositoryFolders.MainWindowAppFolder MainWindow
        {
            get { return _mainwindow; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
    public partial class jenkins_ranorexRepositoryFolders
    {
        /// <summary>
        /// The MainWindowAppFolder folder.
        /// </summary>
        [RepositoryFolder("18240b7c-7140-41f2-9d2a-e8b9c0b2c19d")]
        public partial class MainWindowAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _idtxtboxInfo;

            /// <summary>
            /// Creates a new MainWindow  folder.
            /// </summary>
            public MainWindowAppFolder(RepoGenBaseFolder parentFolder) :
                    base("MainWindow", "/form[@title='MainWindow']", parentFolder, 30000, null, true, "18240b7c-7140-41f2-9d2a-e8b9c0b2c19d", "")
            {
                _idtxtboxInfo = new RepoItemInfo(this, "IdTxtBox", ".//text[@automationid='id_txt_box']", 30000, null, "00e7fc61-8549-4f8f-a651-72299eecdfca");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("18240b7c-7140-41f2-9d2a-e8b9c0b2c19d")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("18240b7c-7140-41f2-9d2a-e8b9c0b2c19d")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The IdTxtBox item.
            /// </summary>
            [RepositoryItem("00e7fc61-8549-4f8f-a651-72299eecdfca")]
            public virtual Ranorex.Text IdTxtBox
            {
                get
                {
                    return _idtxtboxInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The IdTxtBox item info.
            /// </summary>
            [RepositoryItemInfo("00e7fc61-8549-4f8f-a651-72299eecdfca")]
            public virtual RepoItemInfo IdTxtBoxInfo
            {
                get
                {
                    return _idtxtboxInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}