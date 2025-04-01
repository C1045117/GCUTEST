CREATE TABLE `account` (
  `accountId` int(11) NOT NULL AUTO_INCREMENT,
  `accountName` varchar(100) NOT NULL,
  `accountNumber` varchar(45) NOT NULL,
  `accountTypeId` int(11) NOT NULL,
  `currencyId` int(11) NOT NULL DEFAULT '1',
  `accountCashBank` int(11) NOT NULL DEFAULT '0' COMMENT '0=anything, 1=Cash, 2=Bank',
  `accountBankIncome` int(11) NOT NULL DEFAULT '0',
  `accountBankExpense` int(11) NOT NULL DEFAULT '0',
  `accountCashIncome` int(11) NOT NULL DEFAULT '0',
  `accountCashExpense` int(11) NOT NULL DEFAULT '0',
  `accountIsParent` int(11) NOT NULL DEFAULT '0',
  `accountParentId` int(11) NOT NULL DEFAULT '0',
  `accountBalanceAmount` double NOT NULL DEFAULT '0',
  `accountBalanceDate` datetime NOT NULL DEFAULT '2000-01-01 00:00:00',
  `accountActive` int(11) NOT NULL DEFAULT '1',
  `accountBuiltIn` int(11) NOT NULL DEFAULT '0',
  `accountLevel` int(11) NOT NULL DEFAULT '0' COMMENT '0=level 0 (root), 1=level 1 etc',
  `branchId` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`accountId`)
) ENGINE=InnoDB AUTO_INCREMENT=309 DEFAULT CHARSET=latin1;

CREATE TABLE `accounttype` (
  `accountTypeId` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `accountTypeName` varchar(45) NOT NULL,
  PRIMARY KEY (`accountTypeId`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=latin1;

CREATE TABLE `adjustment_types` (
  `adjtypeId` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `adjtypeName` varchar(45) NOT NULL,
  `adjtypeActive` tinyint(3) unsigned NOT NULL DEFAULT '1',
  PRIMARY KEY (`adjtypeId`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

CREATE TABLE `adjustments` (
  `adjId` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `adjMainQty` double NOT NULL,
  `adjAltQty` double NOT NULL DEFAULT '0',
  `adjType` tinyint(1) NOT NULL COMMENT '0=in, 1=out',
  `itemId` smallint(5) unsigned NOT NULL,
  `adjDesc` varchar(150) NOT NULL,
  `adjDate` datetime NOT NULL,
  `adjValue` double NOT NULL COMMENT 'if type=in, we must input the value per each item',
  `storeId` int(10) unsigned NOT NULL,
  `adjCreated` datetime NOT NULL,
  `adjCategory` tinyint(3) unsigned NOT NULL DEFAULT '0' COMMENT '0=biasa, 1=opname',
  PRIMARY KEY (`adjId`)
) ENGINE=InnoDB AUTO_INCREMENT=8706 DEFAULT CHARSET=utf8;

CREATE TABLE `announcement` (
  `announcementId` int(11) NOT NULL AUTO_INCREMENT,
  `announcementDate` datetime NOT NULL,
  `announcementContent` text NOT NULL,
  `announcementPriority` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`announcementId`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=latin1;

CREATE TABLE `announcementgcu` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `content` text NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

CREATE TABLE `bank` (
  `bankId` int(11) NOT NULL AUTO_INCREMENT,
  `bankName` varchar(50) DEFAULT NULL,
  `bankStatus` int(1) DEFAULT '0',
  PRIMARY KEY (`bankId`),
  KEY `bankId` (`bankId`)
) ENGINE=InnoDB AUTO_INCREMENT=57 DEFAULT CHARSET=utf8;

CREATE TABLE `branches` (
  `branchId` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `branchName` varchar(20) NOT NULL,
  `branchCode` varchar(5) NOT NULL,
  `branchActive` int(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`branchId`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;

CREATE TABLE `chequesout` (
  `cheqId` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `cheqNumber` varchar(20) NOT NULL,
  `cheqDate` datetime NOT NULL,
  `bankId` tinyint(3) unsigned NOT NULL,
  `payId` int(10) unsigned NOT NULL DEFAULT '0',
  `mpayId` int(10) unsigned NOT NULL DEFAULT '0',
  `spayId` int(10) unsigned NOT NULL DEFAULT '0' COMMENT 'DELETED?',
  PRIMARY KEY (`cheqId`)
) ENGINE=InnoDB AUTO_INCREMENT=1663 DEFAULT CHARSET=utf8;

CREATE TABLE `currency` (
  `currencyId` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `currencyName` varchar(20) NOT NULL,
  `currencySymbol` varchar(10) NOT NULL,
  `currencyRate` double NOT NULL,
  `currencyActive` int(11) NOT NULL DEFAULT '0',
  `accountPayableId` int(11) NOT NULL DEFAULT '0',
  `accountReceivableId` int(11) NOT NULL DEFAULT '0',
  `advancePurchaseId` int(11) NOT NULL DEFAULT '0',
  `advanceSalesId` int(11) NOT NULL DEFAULT '0',
  `realizeGainLossId` int(11) NOT NULL DEFAULT '0',
  `unrealizeGainLossId` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`currencyId`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

CREATE TABLE `custkode` (
  `CkID` int(11) NOT NULL AUTO_INCREMENT,
  `CkName` varchar(15) DEFAULT NULL,
  `CkStatus` int(1) DEFAULT '0',
  `BranchID` int(11) DEFAULT '0',
  PRIMARY KEY (`CkID`),
  UNIQUE KEY `CkName` (`CkName`),
  KEY `BranchID` (`BranchID`),
  KEY `CkID` (`CkID`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8;

CREATE TABLE `customer` (
  `CustID` int(11) NOT NULL AUTO_INCREMENT,
  `CustName` varchar(50) DEFAULT NULL,
  `CustAddress` varchar(150) DEFAULT NULL,
  `CustCity` varchar(50) DEFAULT NULL,
  `CustPC` varchar(10) DEFAULT NULL,
  `CustPhone` varchar(50) DEFAULT NULL,
  `CustFax` varchar(50) DEFAULT NULL,
  `CustPT` varchar(50) DEFAULT NULL,
  `CustNPWP` varchar(50) DEFAULT NULL,
  `CustTaxAddress` varchar(150) DEFAULT NULL,
  `CustTaxCity` varchar(50) DEFAULT NULL,
  `CustTaxPc` varchar(10) DEFAULT NULL,
  `CustContact` varchar(50) DEFAULT NULL,
  `CustPiutang` int(11) DEFAULT '0',
  `CustTOP` int(11) DEFAULT '0',
  `CustSTOP` int(11) DEFAULT '0',
  `CustSince` datetime DEFAULT NULL,
  `CustNote` varchar(255) DEFAULT NULL,
  `CustCreated` datetime DEFAULT NULL,
  `CustActive` int(1) DEFAULT '0',
  `CustTf` int(1) DEFAULT '0',
  `CkID` int(11) DEFAULT '0',
  `HargaID` int(11) DEFAULT '0',
  `SalesID` int(11) DEFAULT '0',
  `DiscID` int(11) DEFAULT '0',
  `WilId` int(11) DEFAULT '0',
  `BranchId` int(10) unsigned DEFAULT '0',
  `KgId` int(11) DEFAULT '1',
  `TgId` int(11) DEFAULT '1',
  `StoreId` int(11) DEFAULT '1',
  `TagihId` int(10) unsigned DEFAULT '0' COMMENT 'salesId',
  `CustParentId` double DEFAULT '0',
  `isParent` int(11) DEFAULT '0',
  PRIMARY KEY (`CustID`),
  KEY `BranchId` (`BranchId`),
  KEY `CkID` (`CkID`),
  KEY `CustID` (`CustID`),
  KEY `DiscID` (`DiscID`),
  KEY `HargaID` (`HargaID`),
  KEY `KgId` (`KgId`),
  KEY `SalesID` (`SalesID`),
  KEY `StoreId` (`StoreId`),
  KEY `TgId` (`TgId`),
  KEY `WilId` (`WilId`),
  CONSTRAINT `branchId` FOREIGN KEY (`BranchId`) REFERENCES `branches` (`branchId`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `wilId` FOREIGN KEY (`WilId`) REFERENCES `wilayah` (`WilId`)
) ENGINE=InnoDB AUTO_INCREMENT=4367 DEFAULT CHARSET=utf8;

CREATE TABLE `dailystock` (
  `itemId` int(10) unsigned NOT NULL,
  `storeId` int(11) NOT NULL,
  `stockDate` date NOT NULL DEFAULT '2000-01-01',
  `stockTotal` double DEFAULT NULL,
  PRIMARY KEY (`itemId`,`storeId`,`stockDate`),
  KEY `fk_storeId_dailystock_idx` (`storeId`),
  CONSTRAINT `fk_itemId_dailystock` FOREIGN KEY (`itemId`) REFERENCES `items` (`itemId`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_storeId_dailystock` FOREIGN KEY (`storeId`) REFERENCES `storages` (`storeId`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `deliveryorder` (
  `doId` double NOT NULL AUTO_INCREMENT,
  `doNumber` varchar(45) NOT NULL,
  `doDate` datetime NOT NULL,
  `doNote` varchar(100) NOT NULL,
  `doCreated` datetime NOT NULL,
  `storeId` double NOT NULL,
  `custId` int(11) NOT NULL,
  PRIMARY KEY (`doId`),
  KEY `fk_custId` (`custId`),
  CONSTRAINT `fk_custId` FOREIGN KEY (`custId`) REFERENCES `customer` (`CustID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

CREATE TABLE `deliveryorder_item` (
  `id` double NOT NULL AUTO_INCREMENT,
  `doId` double NOT NULL,
  `itemId` int(11) NOT NULL,
  `doQty` double NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

CREATE TABLE `discount` (
  `discId` int(11) NOT NULL AUTO_INCREMENT,
  `discName` varchar(50) NOT NULL,
  `discType` int(11) DEFAULT '0',
  `discPct` varchar(20) DEFAULT '',
  `discStatus` int(1) DEFAULT '0',
  `BranchID` int(11) DEFAULT '0',
  `discOverwrite` int(1) DEFAULT '0',
  PRIMARY KEY (`discId`),
  UNIQUE KEY `discName` (`discName`),
  KEY `BranchID` (`BranchID`),
  KEY `discId` (`discId`)
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=utf8;

CREATE TABLE `discqty` (
  `dqId` int(11) NOT NULL AUTO_INCREMENT,
  `dqBegin` int(11) DEFAULT '0',
  `dqEnd` int(11) DEFAULT '0',
  `dqValue` int(11) DEFAULT '0',
  `discID` int(11) DEFAULT '0',
  PRIMARY KEY (`dqId`),
  KEY `discID` (`discID`),
  KEY `dqId` (`dqId`)
) ENGINE=InnoDB AUTO_INCREMENT=45 DEFAULT CHARSET=utf8;

CREATE TABLE `extras` (
  `exId` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `exName` varchar(100) NOT NULL,
  `exType` tinyint(1) NOT NULL COMMENT '0=individual, 1=monthly',
  `exActive` tinyint(1) NOT NULL,
  PRIMARY KEY (`exId`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

CREATE TABLE `fakturbl` (
  `FbId` int(11) NOT NULL AUTO_INCREMENT,
  `Fs` varchar(50) DEFAULT NULL,
  `FsNew` varchar(50) DEFAULT NULL,
  `ChangeUser` varchar(50) DEFAULT NULL,
  `ChangeDate` datetime DEFAULT NULL,
  `FakturYear` int(11) DEFAULT '0',
  `BranchID` int(11) DEFAULT '0',
  PRIMARY KEY (`FbId`),
  KEY `BranchID` (`BranchID`),
  KEY `FbId` (`FbId`)
) ENGINE=InnoDB AUTO_INCREMENT=308 DEFAULT CHARSET=utf8;

CREATE TABLE `fakturdeleted` (
  `FdId` int(11) NOT NULL AUTO_INCREMENT,
  `Fs` varchar(50) DEFAULT NULL,
  `FdType` int(11) DEFAULT '1',
  `FakturYear` int(11) DEFAULT '0',
  `BranchID` int(11) DEFAULT '0',
  PRIMARY KEY (`FdId`),
  KEY `BranchID` (`BranchID`),
  KEY `FdId` (`FdId`)
) ENGINE=InnoDB AUTO_INCREMENT=668 DEFAULT CHARSET=utf8;

CREATE TABLE `fakturlatest` (
  `fakturYear` int(10) unsigned NOT NULL,
  `fakturLatestNo` int(10) unsigned NOT NULL,
  `salesId` int(10) unsigned NOT NULL DEFAULT '0',
  `branchId` int(10) unsigned NOT NULL DEFAULT '0',
  `fakturType` int(10) unsigned NOT NULL COMMENT '1=Penjualan, 2=Pajak, 3=Int, 4 = Pemb Bs',
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=15323 DEFAULT CHARSET=latin1;

CREATE TABLE `fakturpajak` (
  `FakturPajak` int(11) NOT NULL AUTO_INCREMENT,
  `FsBegin` varchar(50) DEFAULT NULL,
  `FsEnd` varchar(50) DEFAULT NULL,
  `FakturYear` int(11) DEFAULT '0',
  `BranchID` int(11) DEFAULT '0',
  PRIMARY KEY (`FakturPajak`),
  KEY `BranchID` (`BranchID`)
) ENGINE=InnoDB AUTO_INCREMENT=467033 DEFAULT CHARSET=utf8;

CREATE TABLE `faktursales` (
  `FakturSales` int(11) NOT NULL AUTO_INCREMENT,
  `FsBegin` varchar(50) DEFAULT NULL,
  `FsEnd` varchar(50) DEFAULT NULL,
  `salesId` int(11) DEFAULT '0',
  `FakturYear` int(11) DEFAULT '0',
  `BranchID` int(11) DEFAULT '0',
  PRIMARY KEY (`FakturSales`),
  KEY `BranchID` (`BranchID`),
  KEY `salesId` (`salesId`)
) ENGINE=InnoDB AUTO_INCREMENT=98516 DEFAULT CHARSET=utf8;

CREATE TABLE `girocek` (
  `gcId` int(11) NOT NULL AUTO_INCREMENT,
  `gcDate` datetime DEFAULT NULL,
  `gcNo` varchar(50) DEFAULT NULL,
  `gcSetorDate` datetime DEFAULT NULL,
  `gcMasukDate` datetime DEFAULT NULL,
  `bankId` int(11) DEFAULT '0',
  `pbId` int(11) DEFAULT '0',
  `pbgId` int(11) DEFAULT '0',
  `BranchID` int(11) DEFAULT '0',
  `gcReceivedDate` datetime DEFAULT NULL,
  `gcAmount` double DEFAULT '0',
  `custId` double DEFAULT NULL,
  `tgId` int(11) DEFAULT '0',
  PRIMARY KEY (`gcId`),
  KEY `bankId` (`bankId`),
  KEY `BranchID` (`BranchID`),
  KEY `gcId` (`gcId`),
  KEY `pbgId` (`pbgId`),
  KEY `pbId` (`pbId`)
) ENGINE=InnoDB AUTO_INCREMENT=12921 DEFAULT CHARSET=utf8;

CREATE TABLE `group_itemcategory` (
  `groupId` int(10) unsigned NOT NULL,
  `catId` int(10) unsigned NOT NULL,
  PRIMARY KEY (`groupId`,`catId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `groupkg` (
  `groupId` int(11) DEFAULT '0',
  `kgId` int(11) DEFAULT '0',
  `generalDropDown` int(11) DEFAULT '0' COMMENT 'untuk drop down faktur , pembayaran',
  `defaultDropDown` int(11) DEFAULT '0' COMMENT 'untuk default faktur drop down faktur pembelian, pembayaran supplier',
  `transactionDropDown` int(11) DEFAULT '0' COMMENT 'untuk transaksi kas, report kas',
  `showBalance` int(11) DEFAULT '0' COMMENT 'untuk saldo awal report kas',
  KEY `groupId` (`groupId`),
  KEY `kgId` (`kgId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `groupperm` (
  `GpID` int(11) NOT NULL AUTO_INCREMENT,
  `GroupId` int(11) DEFAULT '0',
  `ChildName` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`GpID`),
  KEY `GpID` (`GpID`),
  KEY `GroupId` (`GroupId`),
  KEY `ChildName` (`ChildName`)
) ENGINE=InnoDB AUTO_INCREMENT=14592 DEFAULT CHARSET=utf8;

CREATE TABLE `groups` (
  `groupID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `groupName` varchar(50) DEFAULT NULL,
  `custUpd` int(1) DEFAULT '0',
  `custDel` int(1) DEFAULT '0',
  `penjCreate` int(1) DEFAULT '0',
  `penjUpd` int(1) DEFAULT '0',
  `penjUpdOneDay` int(1) DEFAULT '0',
  `penjDel` int(1) DEFAULT '0',
  `penjSales` int(1) DEFAULT '0',
  `penjFPajak` int(1) DEFAULT '0',
  `penjBsCreate` int(1) DEFAULT '0',
  `penjBsDel` int(1) DEFAULT '0',
  `penjBsUpd` int(1) DEFAULT '0',
  `penjBatasPiutang` int(1) DEFAULT '0',
  `pembDel` int(1) DEFAULT '0',
  `pembUpd` int(1) DEFAULT '0',
  `penjKuiCreate` int(1) DEFAULT '0',
  `penjKuiUpd` int(1) DEFAULT '0',
  `penjModHarga` int(1) DEFAULT '0',
  `penjBsModHarga` int(1) DEFAULT '0',
  `pembModHarga` int(1) DEFAULT '0',
  `penjStockCheck` int(1) DEFAULT '0',
  `penjModNoFPenj` int(1) DEFAULT '0',
  `penjModNoFPajak` int(1) DEFAULT '0',
  `repView` int(1) DEFAULT '0',
  `repPrint` int(1) DEFAULT '0',
  `penjModPemb` int(11) DEFAULT '0',
  `penjUpdLunas` int(11) DEFAULT '0',
  `pembBsUpd` int(1) DEFAULT '0',
  `pembBsModHarga` int(1) DEFAULT '0',
  `pembBsDel` int(1) DEFAULT '0',
  `penjModSec1` int(1) DEFAULT '0',
  `penjModSec2` int(1) DEFAULT '0',
  `custUpdBatasPiutang` int(1) DEFAULT '0',
  `custUpdTop` int(1) DEFAULT '0',
  `kasUpd` int(11) DEFAULT '0',
  `bankUpd` int(11) DEFAULT '0',
  `bankViewSaldo` int(1) DEFAULT '0',
  `pembModPemb` int(1) unsigned DEFAULT '0' COMMENT 'Modify Pembayaran group',
  PRIMARY KEY (`groupID`),
  UNIQUE KEY `groupName` (`groupName`),
  KEY `groupID` (`groupID`)
) ENGINE=InnoDB AUTO_INCREMENT=102 DEFAULT CHARSET=utf8;

CREATE TABLE `groups_branches` (
  `groupId` int(10) unsigned NOT NULL,
  `branchId` int(10) unsigned NOT NULL,
  `generalDropDown` int(10) unsigned NOT NULL DEFAULT '0',
  `defaultDropDown` int(10) unsigned NOT NULL DEFAULT '0',
  PRIMARY KEY (`groupId`,`branchId`),
  KEY `fk_branchId_groups_branches` (`branchId`),
  CONSTRAINT `fk_branchId_groups_branches` FOREIGN KEY (`branchId`) REFERENCES `branches` (`branchId`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_groupId_groups_branches` FOREIGN KEY (`groupId`) REFERENCES `groups` (`groupID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `groups_pages` (
  `groupId` smallint(5) unsigned NOT NULL,
  `pageId` smallint(5) unsigned NOT NULL,
  PRIMARY KEY (`groupId`,`pageId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `groups_permissions` (
  `groupId` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `permId` smallint(5) unsigned NOT NULL,
  `permValue` int(10) unsigned NOT NULL DEFAULT '0',
  PRIMARY KEY (`groupId`,`permId`)
) ENGINE=InnoDB AUTO_INCREMENT=102 DEFAULT CHARSET=utf8;

CREATE TABLE `groups_steps` (
  `groupId` int(10) unsigned NOT NULL,
  `stepId` int(10) unsigned NOT NULL,
  PRIMARY KEY (`groupId`,`stepId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `groups_suppliers` (
  `groupId` int(10) unsigned NOT NULL,
  `supId` int(10) unsigned NOT NULL,
  PRIMARY KEY (`groupId`,`supId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `groupstorage` (
  `groupId` int(11) NOT NULL DEFAULT '0',
  `storeId` int(11) NOT NULL DEFAULT '0',
  `generalDropDown` int(11) NOT NULL DEFAULT '0',
  `defaultDropDown` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`groupId`,`storeId`),
  KEY `groupId` (`groupId`),
  KEY `storeId` (`storeId`),
  KEY `storageId` (`storeId`),
  CONSTRAINT `storageId` FOREIGN KEY (`storeId`) REFERENCES `storages` (`storeId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `grouptg` (
  `groupId` int(11) DEFAULT '0',
  `tgId` int(11) DEFAULT '0',
  `generalDropDown` int(11) DEFAULT '0' COMMENT 'untuk drop down faktur , pembayaran',
  `defaultDropDown` int(11) DEFAULT '0' COMMENT 'untuk default faktur drop down faktur pembelian, pembayaran supplier',
  `transactionDropDown` int(11) DEFAULT '0' COMMENT 'untuk transaksi bank, report bank',
  `showBalance` int(11) DEFAULT '0' COMMENT 'untuk saldo awal report bank',
  KEY `groupId` (`groupId`),
  KEY `tgId` (`tgId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `harga` (
  `HargaID` int(11) NOT NULL AUTO_INCREMENT,
  `HargaKode` varchar(50) DEFAULT NULL,
  `HargaStatus` int(1) DEFAULT '0',
  `BranchID` int(11) DEFAULT '0',
  PRIMARY KEY (`HargaID`),
  UNIQUE KEY `HargaKode` (`HargaKode`),
  KEY `BranchID` (`BranchID`),
  KEY `HargaID` (`HargaID`)
) ENGINE=InnoDB AUTO_INCREMENT=96 DEFAULT CHARSET=utf8;

CREATE TABLE `historytype` (
  `historyTypeId` int(11) NOT NULL,
  `historyTypeName` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`historyTypeId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `itemcategory` (
  `catId` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `catName` varchar(45) NOT NULL,
  `catActive` int(10) unsigned NOT NULL DEFAULT '0',
  PRIMARY KEY (`catId`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=latin1;

CREATE TABLE `itemcomponents` (
  `itemId` int(11) NOT NULL,
  `comId` int(11) NOT NULL,
  PRIMARY KEY (`itemId`,`comId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `itemgroup` (
  `itemId` int(11) NOT NULL,
  `comId` int(11) NOT NULL,
  `qty` double NOT NULL,
  PRIMARY KEY (`itemId`,`comId`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `items` (
  `itemId` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `itemName` varchar(45) NOT NULL,
  `itemAllowPurchase` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'If yes, we can create a purchase invoice to buy this item',
  `itemAllowComponent` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'If yes, this item can be used as a process'' component',
  `itemProcessType` smallint(5) unsigned NOT NULL DEFAULT '0' COMMENT '1=Individual, 2=Individual with average price, 3=1 day mixed with average price, 4=All mixed with average price',
  `itemAllowProcess` tinyint(3) unsigned NOT NULL DEFAULT '0' COMMENT 'If yes, we can process/produce this item',
  `itemMainQty` double NOT NULL DEFAULT '0' COMMENT 'First stock',
  `itemValue` int(10) unsigned NOT NULL DEFAULT '0' COMMENT 'Value of stock (per item, not all)',
  `itemHasParkedQty` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Jumlah yang disetujui',
  `itemHasDeduction` tinyint(1) NOT NULL DEFAULT '0',
  `itemHasExtraPrice` tinyint(1) NOT NULL DEFAULT '0',
  `itemActive` tinyint(1) NOT NULL DEFAULT '1',
  `itemHasStockQty` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'if yes, RECEIVED qty and STOCK qty are different',
  `stepId` int(10) unsigned NOT NULL DEFAULT '0',
  `itemNotRounded` tinyint(1) NOT NULL DEFAULT '0',
  `unitName` varchar(45) NOT NULL,
  `inventoryAccountId` int(11) NOT NULL DEFAULT '0',
  `salesAccountId` int(11) NOT NULL DEFAULT '0',
  `salesReturnAccountId` int(11) NOT NULL DEFAULT '0',
  `salesDiscountAccountId` int(11) NOT NULL DEFAULT '0',
  `goodsInTransitAccountId` int(11) NOT NULL DEFAULT '0',
  `cogsAccountId` int(11) NOT NULL DEFAULT '0',
  `purchaseReturnAccountId` int(11) NOT NULL DEFAULT '0',
  `unbilledGoodsAccountId` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`itemId`)
) ENGINE=InnoDB AUTO_INCREMENT=1498 DEFAULT CHARSET=utf8;

CREATE TABLE `items_extras` (
  `itemId` int(10) unsigned NOT NULL,
  `exId` int(10) unsigned NOT NULL,
  PRIMARY KEY (`itemId`,`exId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `items_storages` (
  `itemId` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `storeId` int(10) unsigned NOT NULL,
  `isQty` double NOT NULL,
  `isFirst` tinyint(1) NOT NULL,
  PRIMARY KEY (`itemId`,`storeId`)
) ENGINE=InnoDB AUTO_INCREMENT=1128 DEFAULT CHARSET=utf8;

CREATE TABLE `items_suppliers` (
  `itemId` int(10) unsigned NOT NULL,
  `supId` int(10) unsigned NOT NULL,
  PRIMARY KEY (`itemId`,`supId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `itemtype` (
  `typeId` int(10) unsigned NOT NULL,
  `typeName` varchar(45) NOT NULL,
  PRIMARY KEY (`typeId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `itemunit` (
  `unitId` double NOT NULL AUTO_INCREMENT,
  `unitNumber` int(11) NOT NULL,
  `unitName` varchar(45) NOT NULL,
  `unitQty` double NOT NULL,
  `itemId` int(11) NOT NULL,
  PRIMARY KEY (`unitId`)
) ENGINE=InnoDB AUTO_INCREMENT=1949 DEFAULT CHARSET=latin1;

CREATE TABLE `journal` (
  `journalId` double NOT NULL AUTO_INCREMENT,
  `journalDate` datetime DEFAULT NULL,
  `journalType` int(11) NOT NULL COMMENT 'type of fkeyId',
  `fkeyId` double NOT NULL,
  `journalDescription` varchar(45) NOT NULL,
  PRIMARY KEY (`journalId`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=589460 DEFAULT CHARSET=latin1;

CREATE TABLE `journaldetail` (
  `id` double NOT NULL AUTO_INCREMENT,
  `journalDebitCredit` smallint(6) NOT NULL DEFAULT '1' COMMENT '1=Debit, 2=Credit',
  `journalAmount` double NOT NULL,
  `accountId` int(11) NOT NULL,
  `journalId` double NOT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_journaldetail_1` (`journalId`),
  CONSTRAINT `FK_journaldetail_1` FOREIGN KEY (`journalId`) REFERENCES `journal` (`journalId`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=1166759 DEFAULT CHARSET=latin1;

CREATE TABLE `kas` (
  `KasId` int(11) NOT NULL AUTO_INCREMENT,
  `KasDesc` varchar(100) DEFAULT NULL,
  `KasType` int(11) DEFAULT '0',
  `KasAmount` int(11) DEFAULT '0',
  `KasDate` datetime DEFAULT NULL,
  `SalesId` int(11) DEFAULT '0',
  `JKasId` int(11) DEFAULT '0',
  `BranchID` int(11) DEFAULT '0',
  `KgId` int(11) DEFAULT '1',
  PRIMARY KEY (`KasId`),
  KEY `BranchID` (`BranchID`),
  KEY `JKasId` (`JKasId`),
  KEY `KgId` (`KgId`),
  KEY `KasId` (`KasId`),
  KEY `SalesId` (`SalesId`)
) ENGINE=InnoDB AUTO_INCREMENT=62261 DEFAULT CHARSET=utf8;

CREATE TABLE `kasjenis` (
  `JKasId` int(11) NOT NULL AUTO_INCREMENT,
  `JKasType` int(11) DEFAULT '0',
  `JKasDesc` varchar(50) DEFAULT NULL,
  `JKasCode` int(11) DEFAULT '0',
  `JKasStatus` int(1) DEFAULT '0',
  `JKasGeneral` varchar(50) DEFAULT NULL,
  `JKasSpecific` varchar(50) DEFAULT NULL,
  `BranchID` int(11) DEFAULT '0',
  `KgId` int(11) DEFAULT '0',
  `TgId` int(11) DEFAULT '0',
  `accountId` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`JKasId`),
  KEY `BranchID` (`BranchID`),
  KEY `JKasCode` (`JKasCode`),
  KEY `JKasId` (`JKasId`),
  KEY `KgId` (`KgId`),
  KEY `TgId` (`TgId`)
) ENGINE=InnoDB AUTO_INCREMENT=68 DEFAULT CHARSET=utf8;

CREATE TABLE `kolektor` (
  `kolId` int(11) NOT NULL AUTO_INCREMENT,
  `kolName` varchar(50) DEFAULT NULL,
  `kolStatus` int(1) DEFAULT '0',
  `BranchID` int(11) DEFAULT '0',
  KEY `BranchID` (`BranchID`),
  KEY `kolId` (`kolId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `kuitansi` (
  `KuiId` int(11) NOT NULL AUTO_INCREMENT,
  `KuiNo` int(11) DEFAULT '0',
  `KuiMonth` int(11) DEFAULT '0',
  `KuiYear` int(11) DEFAULT '0',
  `KuiDate` datetime DEFAULT NULL,
  `KuiAmount` int(11) DEFAULT '0',
  `KuiReceived` varchar(50) DEFAULT NULL,
  `KuiName` varchar(50) DEFAULT NULL,
  `KuiCity` varchar(50) DEFAULT NULL,
  `KuiDeleted` int(1) DEFAULT '0',
  `BranchID` int(11) DEFAULT '0',
  PRIMARY KEY (`KuiId`),
  KEY `BranchID` (`BranchID`),
  KEY `KuiId` (`KuiId`)
) ENGINE=InnoDB AUTO_INCREMENT=17135 DEFAULT CHARSET=utf8;

CREATE TABLE `pages` (
  `pageId` smallint(5) unsigned NOT NULL AUTO_INCREMENT,
  `pageName` varchar(45) NOT NULL DEFAULT '',
  `pageMenu` varchar(45) DEFAULT NULL COMMENT 'VB menu name',
  `pagePriority` smallint(5) unsigned NOT NULL DEFAULT '0',
  `parentId` int(10) unsigned NOT NULL DEFAULT '0',
  `pageIsParent` smallint(6) DEFAULT '0',
  `pageLevel` smallint(6) NOT NULL DEFAULT '0',
  `pageSeparator` smallint(6) NOT NULL DEFAULT '0',
  `pageAlways` tinyint(1) DEFAULT '0',
  `pageFile` varchar(45) DEFAULT NULL,
  `pageWindow` varchar(45) DEFAULT NULL,
  `pageWidth` smallint(5) DEFAULT NULL,
  `pageHeight` smallint(5) DEFAULT NULL,
  PRIMARY KEY (`pageId`)
) ENGINE=InnoDB AUTO_INCREMENT=118 DEFAULT CHARSET=latin1;

CREATE TABLE `paymentcodes` (
  `pcId` tinyint(3) unsigned NOT NULL,
  `pcName` varchar(10) NOT NULL DEFAULT '',
  `pcActive` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`pcId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `pembkode` (
  `PkID` int(11) NOT NULL AUTO_INCREMENT,
  `PkName` varchar(50) DEFAULT NULL,
  `PkStatus` int(1) DEFAULT '0',
  PRIMARY KEY (`PkID`),
  UNIQUE KEY `PkName` (`PkName`),
  KEY `PkID` (`PkID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

CREATE TABLE `penjbayar` (
  `PbID` int(11) NOT NULL AUTO_INCREMENT,
  `PbDate` datetime DEFAULT NULL,
  `PbAmount` double DEFAULT '0',
  `PkID` int(11) DEFAULT '0',
  `PenjID` int(11) DEFAULT '0',
  `SalesId` int(11) DEFAULT '0',
  `PbBs` int(1) DEFAULT '0',
  `PbgId` int(11) DEFAULT '0',
  `CreatedDate` datetime DEFAULT NULL,
  `accountId` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`PbID`),
  KEY `PbgId` (`PbgId`),
  KEY `PbID` (`PbID`),
  KEY `PenjID` (`PenjID`),
  KEY `PkID` (`PkID`),
  KEY `SalesId` (`SalesId`)
) ENGINE=InnoDB AUTO_INCREMENT=779363 DEFAULT CHARSET=utf8;

CREATE TABLE `penjbayargroup` (
  `PbgID` int(11) NOT NULL AUTO_INCREMENT,
  `PbgDate` datetime DEFAULT NULL,
  `PbgAmount` double DEFAULT '0',
  `PkID` int(11) DEFAULT '0',
  `SalesId` int(11) DEFAULT '0',
  `CustId` double unsigned DEFAULT '0',
  `createdDate` datetime DEFAULT NULL,
  `AllocatedAmount` double NOT NULL DEFAULT '0',
  `accountId` int(11) NOT NULL DEFAULT '0',
  `pbgNote` varchar(100) NOT NULL DEFAULT '',
  PRIMARY KEY (`PbgID`),
  KEY `PbgID` (`PbgID`),
  KEY `PkID` (`PkID`),
  KEY `SalesId` (`SalesId`)
) ENGINE=InnoDB AUTO_INCREMENT=39766 DEFAULT CHARSET=utf8;

CREATE TABLE `penjbs` (
  `penjId` int(11) DEFAULT '0',
  `penjBsId` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`penjBsId`),
  KEY `penjBsId` (`penjBsId`),
  KEY `penjId` (`penjId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `penjkui` (
  `kuiId` int(11) DEFAULT '0',
  `penjId` int(11) DEFAULT '0',
  KEY `kuiId` (`kuiId`),
  KEY `penjId` (`penjId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `penjprod` (
  `PpID` int(11) NOT NULL AUTO_INCREMENT,
  `PpAmount` double DEFAULT '0',
  `PpMissing` double DEFAULT '0',
  `PpPrice` int(11) DEFAULT '0',
  `PpPriceOrig` int(11) DEFAULT '0',
  `PenjID` int(11) DEFAULT '0',
  `ProdID` int(11) DEFAULT '0',
  `soId` double NOT NULL DEFAULT '0',
  `doId` double DEFAULT NULL,
  `ppDescription` varchar(100) DEFAULT '',
  `parentItemId` int(11) DEFAULT '0',
  PRIMARY KEY (`PpID`),
  KEY `PenjID` (`PenjID`),
  KEY `PpID` (`PpID`),
  KEY `ProdID` (`ProdID`),
  KEY `soId` (`soId`),
  KEY `fk_doId` (`doId`),
  CONSTRAINT `fk_doId` FOREIGN KEY (`doId`) REFERENCES `deliveryorder` (`doId`) ON DELETE SET NULL,
  CONSTRAINT `penjprod_ibfk_1` FOREIGN KEY (`ProdID`) REFERENCES `produk` (`ProdID`)
) ENGINE=InnoDB AUTO_INCREMENT=2940767 DEFAULT CHARSET=utf8;

CREATE TABLE `penjservice` (
  `PsID` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `PsDesc` varchar(200) NOT NULL,
  `PsValue` double NOT NULL,
  `PenjID` int(11) NOT NULL,
  PRIMARY KEY (`PsID`),
  KEY `FK_penjservice_1` (`PenjID`),
  CONSTRAINT `FK_penjservice_1` FOREIGN KEY (`PenjID`) REFERENCES `penjualan` (`PenjID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `penjualan` (
  `PenjID` int(11) NOT NULL AUTO_INCREMENT,
  `PenjFaktur` varchar(50) DEFAULT NULL,
  `PenjFP` int(11) DEFAULT '0',
  `PenjDate` datetime DEFAULT NULL,
  `PenjDateFP` datetime DEFAULT NULL,
  `PenjKode` int(4) DEFAULT '0',
  `PenjTotal` int(11) DEFAULT '0',
  `PenjTotalOrig` int(11) DEFAULT '0',
  `PenjBs` int(11) DEFAULT '0',
  `PenjDisc` int(11) DEFAULT '0',
  `PenjDiscDesc` varchar(50) DEFAULT NULL,
  `PenjPot` int(11) DEFAULT '0',
  `OldPenjBayar` int(11) DEFAULT '0',
  `PenjBayar` int(11) DEFAULT '0',
  `PenjDpp` int(11) DEFAULT '0',
  `PenjPpn` int(11) DEFAULT '0',
  `PenjNote` varchar(255) DEFAULT NULL,
  `PenjTf` int(11) DEFAULT '0',
  `PenjDateTf` datetime DEFAULT NULL,
  `PenjTg` int(11) DEFAULT '0',
  `PenjOldPrice` int(1) DEFAULT '0',
  `PenjLunas` datetime DEFAULT NULL,
  `PenjCreated` datetime DEFAULT NULL,
  `PenjPrintKomTotal` int(11) DEFAULT '0',
  `PenjPrintPajakTotal` int(11) DEFAULT '0',
  `CustID` int(11) DEFAULT '0',
  `HargaID` int(11) DEFAULT '0',
  `SalesID` int(11) DEFAULT '0',
  `CkId` int(11) DEFAULT '0',
  `WilId` int(11) DEFAULT '0',
  `BranchID` int(11) DEFAULT '0',
  `PenjAuth` int(1) DEFAULT '0',
  `PenjBsType` int(11) DEFAULT '0',
  `StoreId` int(11) DEFAULT '1',
  `PenjCloseDate` datetime DEFAULT NULL,
  PRIMARY KEY (`PenjID`),
  KEY `BranchID` (`BranchID`),
  KEY `CkId` (`CkId`),
  KEY `CustID` (`CustID`),
  KEY `HargaID` (`HargaID`),
  KEY `PenjID` (`PenjID`),
  KEY `SalesID` (`SalesID`),
  KEY `StoreId` (`StoreId`),
  KEY `WilId` (`WilId`),
  KEY `PenjDate` (`PenjDate`),
  KEY `PenjFaktur` (`PenjFaktur`),
  KEY `PenjFP` (`PenjFP`),
  KEY `PenjDateFP` (`PenjDateFP`),
  CONSTRAINT `penjualan_ibfk_1` FOREIGN KEY (`CustID`) REFERENCES `customer` (`CustID`),
  CONSTRAINT `storeId` FOREIGN KEY (`StoreId`) REFERENCES `storages` (`storeId`)
) ENGINE=InnoDB AUTO_INCREMENT=631036 DEFAULT CHARSET=utf8;

CREATE TABLE `permissions` (
  `permId` smallint(5) unsigned NOT NULL AUTO_INCREMENT,
  `permName` varchar(45) NOT NULL,
  `permDesc` varchar(100) NOT NULL,
  `permPriority` smallint(5) unsigned NOT NULL,
  `permType` smallint(5) unsigned NOT NULL,
  PRIMARY KEY (`permId`)
) ENGINE=InnoDB AUTO_INCREMENT=47 DEFAULT CHARSET=latin1;

CREATE TABLE `processcomponents` (
  `comId` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `comMainQty` double NOT NULL,
  `comAltQty` double NOT NULL DEFAULT '0',
  `comCost` int(10) unsigned NOT NULL DEFAULT '0' COMMENT 'WILL BE DELETED',
  `itemId` smallint(5) unsigned NOT NULL DEFAULT '0' COMMENT 'we need this for pro 3 and 4',
  `proId` int(10) unsigned NOT NULL,
  `iiId` int(10) unsigned NOT NULL DEFAULT '0',
  `comProId` int(10) unsigned NOT NULL DEFAULT '0',
  `comProcessType` tinyint(3) unsigned NOT NULL DEFAULT '0' COMMENT 'added so process type can be changed',
  `comIsWaste` tinyint(1) NOT NULL DEFAULT '0' COMMENT '0=not waste, 1=waste',
  `storeId` int(10) unsigned NOT NULL DEFAULT '0',
  `comDate` datetime NOT NULL,
  `comOth` tinyint(1) unsigned NOT NULL DEFAULT '0',
  PRIMARY KEY (`comId`)
) ENGINE=InnoDB AUTO_INCREMENT=360879 DEFAULT CHARSET=utf8;

CREATE TABLE `processes` (
  `proId` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `proNumber` varchar(20) CHARACTER SET latin1 NOT NULL DEFAULT '',
  `proDate` datetime NOT NULL,
  `proMainQty` double NOT NULL,
  `proAltQty` double NOT NULL DEFAULT '0',
  `itemId` smallint(5) unsigned NOT NULL,
  `proMainQtyUsed` double NOT NULL DEFAULT '0',
  `proAltQtyUsed` double NOT NULL DEFAULT '0',
  `proWaste` double NOT NULL DEFAULT '0',
  `proWasteUsed` double NOT NULL DEFAULT '0',
  `storeId` int(10) unsigned NOT NULL DEFAULT '0',
  `proCreated` datetime NOT NULL,
  PRIMARY KEY (`proId`)
) ENGINE=InnoDB AUTO_INCREMENT=107669 DEFAULT CHARSET=utf8;

CREATE TABLE `processextras` (
  `pexId` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `pexDesc` varchar(200) NOT NULL,
  `pexCost` double NOT NULL DEFAULT '0',
  `proId` int(10) unsigned NOT NULL,
  `exId` int(10) unsigned NOT NULL,
  `kgId` int(10) unsigned NOT NULL DEFAULT '0',
  PRIMARY KEY (`pexId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `processextrasmonthly` (
  `pexId` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `pexDesc` varchar(200) NOT NULL,
  `pexCost` double NOT NULL DEFAULT '0',
  `pexStartDate` datetime NOT NULL,
  `pexEndDate` datetime NOT NULL,
  `exId` int(10) unsigned NOT NULL,
  PRIMARY KEY (`pexId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `prodbranches` (
  `prodId` int(10) unsigned NOT NULL,
  `branchId` int(10) unsigned NOT NULL,
  `prodMin` double NOT NULL DEFAULT '0',
  PRIMARY KEY (`prodId`,`branchId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `proddetails` (
  `ProdStock` double DEFAULT '0',
  `ProdCost` double DEFAULT '0',
  `ProdMin` double DEFAULT '0',
  `ProdStatus` int(1) DEFAULT '0',
  `ProdId` int(11) DEFAULT '0',
  `BranchId` int(11) DEFAULT '0',
  KEY `BranchId` (`BranchId`),
  KEY `ProdId` (`ProdId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `prodharga` (
  `PhAmount` double DEFAULT '0',
  `ProdId` int(11) DEFAULT '0',
  `HargaId` int(11) DEFAULT '0',
  KEY `HargaId` (`HargaId`),
  KEY `ProdId` (`ProdId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `produk` (
  `ProdID` int(11) NOT NULL AUTO_INCREMENT,
  `ProdName` varchar(45) DEFAULT NULL,
  `ProdLongName` varchar(50) DEFAULT '',
  `ProdBox` varchar(50) DEFAULT '',
  `ProdStock` double DEFAULT '0',
  `ProdStockBs` double DEFAULT '0',
  `ProdCost` double DEFAULT '0',
  `ProdMin` double DEFAULT '0',
  `ProdTea` int(1) DEFAULT '0',
  `ProdStatus` int(1) DEFAULT '1',
  `ProdExpress` int(1) DEFAULT '0',
  `PsID` int(11) DEFAULT '1',
  `catId` int(11) DEFAULT '1',
  `ProdAllowSell` int(11) DEFAULT '0',
  `typeId` int(11) DEFAULT '1',
  `taxInvoiceUnitId` double NOT NULL DEFAULT '0',
  PRIMARY KEY (`ProdID`),
  UNIQUE KEY `ProdName` (`ProdName`),
  KEY `ProdID` (`ProdID`),
  KEY `PsID` (`PsID`)
) ENGINE=InnoDB AUTO_INCREMENT=1498 DEFAULT CHARSET=utf8;

CREATE TABLE `produksatuan` (
  `PsID` int(11) NOT NULL AUTO_INCREMENT,
  `PsName` varchar(50) DEFAULT NULL,
  `PsLargeName` varchar(50) DEFAULT NULL,
  `PsSmallName` varchar(50) DEFAULT NULL,
  `PsQty` int(11) DEFAULT '0',
  PRIMARY KEY (`PsID`),
  KEY `PsID` (`PsID`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;

CREATE TABLE `produkstorages` (
  `psId` int(11) NOT NULL AUTO_INCREMENT,
  `ProdId` int(11) DEFAULT '0',
  `StoreId` int(11) DEFAULT '0',
  `psAvailable` int(11) DEFAULT '0' COMMENT '1=product available in storage',
  `psQty` double DEFAULT '0',
  `psQtyBs` double DEFAULT '0',
  `psPrice` double DEFAULT '0' COMMENT 'Price per Item (average price)',
  PRIMARY KEY (`psId`),
  KEY `ProdId` (`ProdId`),
  KEY `psId` (`psId`),
  KEY `fk_produkstorages_storeId_idx` (`StoreId`),
  CONSTRAINT `fk_produkstorages_prodId` FOREIGN KEY (`ProdId`) REFERENCES `produk` (`ProdID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_produkstorages_storeId` FOREIGN KEY (`StoreId`) REFERENCES `storages` (`storeId`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=1427351 DEFAULT CHARSET=utf8;

CREATE TABLE `purchaseinvoice_receiveditem` (
  `invId` double NOT NULL,
  `riId` double NOT NULL,
  PRIMARY KEY (`invId`,`riId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `purchaseinvoices` (
  `invId` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `invNumber` varchar(45) CHARACTER SET latin1 NOT NULL,
  `invDate` datetime NOT NULL,
  `invCode` int(10) unsigned NOT NULL DEFAULT '0' COMMENT '0=Tunai;

CREATE TABLE `purchaseinvoices_items` (
  `iiId` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `iiMainQty` double NOT NULL COMMENT 'qty which is used for stock calculation',
  `iiAltQty` double NOT NULL DEFAULT '0',
  `iiParkedQty` double DEFAULT '0',
  `iiPrice` double NOT NULL DEFAULT '0',
  `invId` int(10) unsigned NOT NULL,
  `itemId` int(10) unsigned NOT NULL,
  `iiMainQtyUsed` double NOT NULL DEFAULT '0',
  `iiAltQtyUsed` double NOT NULL DEFAULT '0',
  `iiAgreedQty` double NOT NULL DEFAULT '0',
  `iiDeduction` double NOT NULL DEFAULT '0' COMMENT 'percentage of deduction',
  `iiExtraPrice` double NOT NULL DEFAULT '0' COMMENT 'additional price',
  `iiNetQty` double NOT NULL DEFAULT '0',
  `storeId` int(10) unsigned NOT NULL,
  `iiQty` double NOT NULL COMMENT 'qty which is used to calculate invoice value',
  `riId` double DEFAULT NULL,
  `riItemId` double NOT NULL DEFAULT '0',
  `currencyId` int(11) NOT NULL DEFAULT '1',
  `currencyRate` double NOT NULL DEFAULT '1',
  `unitName` varchar(45) NOT NULL DEFAULT ' ',
  `iiDescription` varchar(100) NOT NULL DEFAULT '',
  PRIMARY KEY (`iiId`),
  KEY `invId` (`invId`),
  KEY `riId` (`riId`),
  CONSTRAINT `fk_purchaseinvoices_items_riid` FOREIGN KEY (`riId`) REFERENCES `receiveditem` (`riId`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=982271 DEFAULT CHARSET=utf8;

CREATE TABLE `purchaseinvoices_multipayments` (
  `mpayId` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `mpayDate` datetime NOT NULL,
  `mpayAmount` double NOT NULL DEFAULT '0',
  `pcId` tinyint(3) unsigned NOT NULL,
  `supId` smallint(5) unsigned NOT NULL,
  `mpayInFront` tinyint(1) NOT NULL DEFAULT '0',
  `mpayNote` varchar(100) CHARACTER SET latin1 NOT NULL DEFAULT ' ',
  `accountId` int(11) NOT NULL DEFAULT '0',
  `mpayOth` tinyint(1) NOT NULL DEFAULT '0',
  `mpayOther` double NOT NULL DEFAULT '0' COMMENT 'Other=Potongan(Deduction)',
  `mpayCreated` datetime DEFAULT NULL,
  `mpayAllocated` double NOT NULL DEFAULT '0',
  `currencyRate` double NOT NULL DEFAULT '1',
  PRIMARY KEY (`mpayId`)
) ENGINE=InnoDB AUTO_INCREMENT=14730 DEFAULT CHARSET=utf8;

CREATE TABLE `purchaseinvoices_payments` (
  `payId` double NOT NULL AUTO_INCREMENT,
  `payDate` datetime NOT NULL,
  `payAmount` double NOT NULL DEFAULT '0',
  `pcId` tinyint(3) unsigned NOT NULL DEFAULT '0',
  `invId` int(10) unsigned NOT NULL DEFAULT '0',
  `ipgId` int(10) unsigned NOT NULL DEFAULT '0' COMMENT 'Will be removed???',
  `mpayId` double NOT NULL DEFAULT '0',
  `payInFront` tinyint(1) NOT NULL DEFAULT '0',
  `supId` int(11) NOT NULL DEFAULT '0' COMMENT 'Used to pay first balance',
  `payCreated` datetime DEFAULT NULL,
  `pbgId` double NOT NULL DEFAULT '0',
  `currencyRate` double NOT NULL DEFAULT '1',
  `accountId` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`payId`),
  KEY `invId_idx` (`invId`),
  KEY `pcId_idx` (`pcId`),
  KEY `payCreated` (`payCreated`),
  CONSTRAINT `invId` FOREIGN KEY (`invId`) REFERENCES `purchaseinvoices` (`invId`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `pcId` FOREIGN KEY (`pcId`) REFERENCES `paymentcodes` (`pcId`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=331941 DEFAULT CHARSET=utf8;

CREATE TABLE `purchaseinvoices_returns` (
  `invId` double NOT NULL,
  `invReturnId` double NOT NULL,
  PRIMARY KEY (`invId`,`invReturnId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `purchaseorder` (
  `poId` int(11) NOT NULL AUTO_INCREMENT,
  `poNumber` varchar(50) DEFAULT NULL,
  `poDate` datetime DEFAULT NULL,
  `poExpired` datetime DEFAULT NULL,
  `poAmount` double DEFAULT '0',
  `custId` double DEFAULT '0',
  `penjId` double DEFAULT '0',
  PRIMARY KEY (`poId`),
  KEY `custId` (`custId`),
  KEY `penjId` (`penjId`),
  KEY `poId` (`poId`)
) ENGINE=InnoDB AUTO_INCREMENT=5979 DEFAULT CHARSET=utf8;

CREATE TABLE `purchaseprice` (
  `id` double NOT NULL AUTO_INCREMENT,
  `itemId` int(11) NOT NULL,
  `supId` int(11) NOT NULL,
  `itemPrice` double NOT NULL DEFAULT '0',
  `validFromDate` datetime NOT NULL,
  `unitId` double NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=32044 DEFAULT CHARSET=latin1;

CREATE TABLE `receiveditem` (
  `riId` double NOT NULL AUTO_INCREMENT,
  `riNumber` varchar(45) CHARACTER SET latin1 NOT NULL,
  `riDate` datetime NOT NULL,
  `riNote` varchar(100) CHARACTER SET latin1 NOT NULL,
  `riCreated` datetime NOT NULL,
  `storeId` int(11) NOT NULL,
  `supId` double NOT NULL,
  PRIMARY KEY (`riId`),
  KEY `fk_receiveditem_storeid_idx` (`storeId`),
  CONSTRAINT `fk_receiveditem_storeid` FOREIGN KEY (`storeId`) REFERENCES `storages` (`storeId`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=154713 DEFAULT CHARSET=utf8;

CREATE TABLE `receiveditem_item` (
  `riItemId` double NOT NULL AUTO_INCREMENT,
  `riId` double NOT NULL,
  `itemId` int(10) unsigned NOT NULL,
  `riQty` double NOT NULL,
  `riMainQty` double NOT NULL COMMENT 'stock based on Supplier''s unit',
  `unitName` varchar(45) NOT NULL DEFAULT ' ',
  PRIMARY KEY (`riItemId`),
  KEY `riId` (`riId`),
  CONSTRAINT `riId` FOREIGN KEY (`riId`) REFERENCES `receiveditem` (`riId`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=196785 DEFAULT CHARSET=latin1;

CREATE TABLE `sales` (
  `SalesID` int(11) NOT NULL AUTO_INCREMENT,
  `SalesName` varchar(25) DEFAULT NULL,
  `SalesKol` int(1) DEFAULT '0',
  `SalesFakNo` varchar(50) DEFAULT '',
  `SalesFakStatus` int(1) DEFAULT '0',
  `SalesFakPajak` int(1) DEFAULT '0',
  `LatestFakPenj` int(11) DEFAULT '0',
  `LatestFakPajak` int(11) DEFAULT '0',
  `SalesStatus` int(1) DEFAULT '0',
  `BranchID` int(11) DEFAULT '0',
  `SalesDonation` int(1) unsigned DEFAULT '0',
  PRIMARY KEY (`SalesID`),
  KEY `BranchID` (`BranchID`),
  KEY `SalesID` (`SalesID`)
) ENGINE=InnoDB AUTO_INCREMENT=352 DEFAULT CHARSET=utf8;

CREATE TABLE `salesorder` (
  `soId` double NOT NULL AUTO_INCREMENT,
  `soNumber` varchar(45) NOT NULL,
  `poNumber` varchar(45) NOT NULL,
  `soDate` datetime NOT NULL,
  `soExpiredDate` datetime NOT NULL,
  `soTotalPrice` double NOT NULL,
  `soDiscount` double NOT NULL,
  `soDiscountDescription` varchar(45) NOT NULL,
  `soNote` varchar(100) NOT NULL,
  `soCreatedDate` datetime NOT NULL,
  `custId` double NOT NULL,
  `penjId` double NOT NULL DEFAULT '0',
  PRIMARY KEY (`soId`)
) ENGINE=InnoDB AUTO_INCREMENT=29780 DEFAULT CHARSET=latin1;

CREATE TABLE `salesorder_item` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `soId` double NOT NULL,
  `itemId` int(11) NOT NULL,
  `itemQty` double NOT NULL,
  `itemPrice` double NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=70142 DEFAULT CHARSET=latin1;

CREATE TABLE `salestarget` (
  `stId` int(11) NOT NULL AUTO_INCREMENT,
  `stBegin` int(11) DEFAULT '0',
  `stEnd` int(11) DEFAULT '0',
  `stYear` int(11) DEFAULT '0',
  `stNewTarget` int(11) DEFAULT '0',
  `stPrevTarget` int(11) DEFAULT '0',
  `stPct` int(11) DEFAULT '0',
  `salesId` int(11) DEFAULT '0',
  PRIMARY KEY (`stId`),
  KEY `salesId` (`salesId`),
  KEY `stId` (`stId`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

CREATE TABLE `settings` (
  `SetId` int(11) NOT NULL AUTO_INCREMENT,
  `SetName` varchar(150) DEFAULT NULL,
  `SetVal` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`SetId`),
  KEY `SetId` (`SetId`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8;

CREATE TABLE `settingsprint` (
  `setId` int(11) NOT NULL AUTO_INCREMENT,
  `printCompany` varchar(50) DEFAULT NULL,
  `printNote1` varchar(50) DEFAULT NULL,
  `printNote2` varchar(50) DEFAULT NULL,
  `printNote3` varchar(50) DEFAULT NULL,
  `printCity` varchar(50) DEFAULT NULL,
  `printTaxName` varchar(50) DEFAULT NULL,
  `printPosition` varchar(50) DEFAULT NULL,
  `printKuiName` varchar(50) DEFAULT NULL,
  `printKuiCity` varchar(50) DEFAULT NULL,
  `salesReceiptCode` varchar(10) DEFAULT NULL,
  `salesReceiptDescription` varchar(45) DEFAULT 'Untuk pembayaran Teh GOPEK',
  `printTaxAddress` varchar(120) DEFAULT NULL,
  `printTaxNumber` varchar(45) DEFAULT NULL,
  `printNPWP` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`setId`),
  KEY `setId` (`setId`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

CREATE TABLE `standardcomponents` (
  `itemId` int(11) NOT NULL,
  `comId` int(11) NOT NULL,
  `storeId` int(11) NOT NULL,
  `standardQty` double NOT NULL,
  PRIMARY KEY (`itemId`,`comId`,`storeId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `standardusage` (
  `itemId` int(11) NOT NULL,
  `comId` int(11) NOT NULL,
  `branchId` int(11) NOT NULL,
  `qty` double NOT NULL,
  PRIMARY KEY (`itemId`,`comId`,`branchId`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `steps` (
  `stepId` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `stepName` varchar(100) NOT NULL,
  PRIMARY KEY (`stepId`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

CREATE TABLE `steps_items` (
  `stepId` int(10) unsigned NOT NULL,
  `itemId` int(10) unsigned NOT NULL,
  PRIMARY KEY (`stepId`,`itemId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `storages` (
  `storeId` int(11) NOT NULL AUTO_INCREMENT,
  `storeName` varchar(50) DEFAULT NULL,
  `storeMkt` int(1) DEFAULT '0',
  `storeProd` int(1) DEFAULT '0',
  `storeActive` int(1) DEFAULT '0',
  `BranchId` int(10) unsigned DEFAULT NULL,
  `storeReturn` int(11) DEFAULT '0',
  PRIMARY KEY (`storeId`),
  KEY `storeId` (`storeId`)
) ENGINE=InnoDB AUTO_INCREMENT=383 DEFAULT CHARSET=utf8;

CREATE TABLE `suppliers` (
  `supId` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `supCode` varchar(10) NOT NULL,
  `supName` varchar(45) NOT NULL,
  `supAddress` varchar(150) NOT NULL,
  `supNPWP` varchar(45) NOT NULL,
  `supActive` tinyint(1) NOT NULL,
  `supUnpaid` double NOT NULL DEFAULT '0' COMMENT 'Total money that we haven''t paid at the time the program is used for the first time',
  `supPayment` double NOT NULL DEFAULT '0' COMMENT 'Payment for Unpaid',
  `supPayInFront` tinyint(1) NOT NULL DEFAULT '1' COMMENT 'if 1, Supplier can be paid before the due date for payment (BON)',
  `supAutoAlloc` tinyint(3) NOT NULL DEFAULT '1' COMMENT 'if 1, multi payment for Suppliers can be allocated automatically (FIFO)',
  `kgId` int(11) NOT NULL DEFAULT '0',
  `tgId` int(11) NOT NULL DEFAULT '0',
  `supParentId` int(11) NOT NULL DEFAULT '0',
  `isParent` int(11) NOT NULL DEFAULT '0',
  `currencyId` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`supId`)
) ENGINE=InnoDB AUTO_INCREMENT=501 DEFAULT CHARSET=utf8;

CREATE TABLE `transactions` (
  `TransId` int(11) NOT NULL AUTO_INCREMENT,
  `TransDesc` varchar(100) DEFAULT NULL,
  `TransType` int(11) DEFAULT '0',
  `TransAmount` double DEFAULT '0',
  `TransDate` datetime DEFAULT NULL,
  `ttId` double DEFAULT '0',
  `BranchID` int(11) DEFAULT '0',
  `tgId` int(11) DEFAULT '0',
  PRIMARY KEY (`TransId`),
  KEY `BranchID` (`BranchID`),
  KEY `ttId` (`ttId`),
  KEY `TransId` (`TransId`),
  KEY `tgId` (`tgId`)
) ENGINE=InnoDB AUTO_INCREMENT=3000 DEFAULT CHARSET=utf8;

CREATE TABLE `transactionstype` (
  `ttId` int(11) NOT NULL AUTO_INCREMENT,
  `ttType` int(11) DEFAULT '0',
  `ttDesc` varchar(50) DEFAULT NULL,
  `ttCode` int(11) DEFAULT '0',
  `ttActive` int(1) DEFAULT '0',
  `BranchID` int(11) DEFAULT '0',
  `kgId` int(11) DEFAULT '0',
  `tgId` int(11) DEFAULT '0',
  `accountId` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`ttId`),
  KEY `BranchID` (`BranchID`),
  KEY `ttCode` (`ttCode`),
  KEY `ttId` (`ttId`)
) ENGINE=InnoDB AUTO_INCREMENT=62 DEFAULT CHARSET=utf8;

CREATE TABLE `transfer` (
  `transferId` double NOT NULL AUTO_INCREMENT,
  `transferNumber` varchar(45) NOT NULL,
  `transferDate` datetime NOT NULL,
  `storageFromId` int(11) NOT NULL,
  `storageToId` int(11) NOT NULL,
  `transferCreated` datetime NOT NULL,
  PRIMARY KEY (`transferId`)
) ENGINE=InnoDB AUTO_INCREMENT=659311 DEFAULT CHARSET=latin1;

CREATE TABLE `transfer_item` (
  `id` double NOT NULL AUTO_INCREMENT,
  `itemId` int(11) NOT NULL,
  `transferQty` double NOT NULL,
  `transferId` double NOT NULL,
  PRIMARY KEY (`id`),
  KEY `transferId` (`transferId`),
  KEY `itemId` (`itemId`),
  CONSTRAINT `transfer_item_ibfk_1` FOREIGN KEY (`transferId`) REFERENCES `transfer` (`transferId`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4104232 DEFAULT CHARSET=latin1;

CREATE TABLE `treelist` (
  `TreeID` int(11) NOT NULL AUTO_INCREMENT,
  `parentName` varchar(50) DEFAULT NULL,
  `childName` varchar(50) DEFAULT NULL,
  `frmName` varchar(50) DEFAULT NULL,
  `Priority` int(11) DEFAULT '0',
  PRIMARY KEY (`TreeID`),
  KEY `TreeID` (`TreeID`)
) ENGINE=InnoDB AUTO_INCREMENT=54 DEFAULT CHARSET=utf8;

CREATE TABLE `usage_item` (
  `usageId` int(11) NOT NULL,
  `itemId` int(11) NOT NULL,
  `useQty` double DEFAULT NULL,
  `wasteQty` double DEFAULT NULL,
  PRIMARY KEY (`usageId`,`itemId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `usages` (
  `usageId` int(11) NOT NULL AUTO_INCREMENT,
  `usageNumber` varchar(45) NOT NULL,
  `usageDate` datetime NOT NULL,
  `usageNote` varchar(100) DEFAULT NULL,
  `usageCreated` datetime NOT NULL,
  `storeId` int(11) NOT NULL,
  PRIMARY KEY (`usageId`)
) ENGINE=InnoDB AUTO_INCREMENT=371671 DEFAULT CHARSET=latin1;

CREATE TABLE `userlist` (
  `UserId` int(11) NOT NULL AUTO_INCREMENT,
  `UserLogin` varchar(50) DEFAULT NULL,
  `UserPassword` varchar(50) DEFAULT NULL,
  `UserStatus` int(1) DEFAULT '0',
  `GroupId` int(11) DEFAULT '0',
  `BranchID` int(11) DEFAULT '0',
  PRIMARY KEY (`UserId`),
  KEY `BranchID` (`BranchID`),
  KEY `GroupId` (`GroupId`),
  KEY `UserId` (`UserId`)
) ENGINE=InnoDB AUTO_INCREMENT=271 DEFAULT CHARSET=utf8;

CREATE TABLE `users` (
  `userId` smallint(6) NOT NULL AUTO_INCREMENT,
  `userLogin` varchar(20) NOT NULL DEFAULT '',
  `userPassword` varchar(20) NOT NULL DEFAULT '',
  `userActive` tinyint(1) NOT NULL DEFAULT '0',
  `groupId` int(10) unsigned NOT NULL DEFAULT '0',
  `branchId` smallint(5) unsigned NOT NULL DEFAULT '0',
  `userOth` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`userId`)
) ENGINE=InnoDB AUTO_INCREMENT=66 DEFAULT CHARSET=utf8;

CREATE TABLE `voucher` (
  `voucherId` double NOT NULL AUTO_INCREMENT,
  `voucherNumber` varchar(45) NOT NULL,
  `voucherDate` datetime NOT NULL,
  `voucherType` int(11) NOT NULL DEFAULT '1' COMMENT '1=journal voucher, 2=Cash, 3=Bank',
  `voucherNote` varchar(200) NOT NULL,
  `salesId` int(11) NOT NULL DEFAULT '0',
  `voucherCreated` datetime NOT NULL,
  `voucherDescription` varchar(100) NOT NULL,
  PRIMARY KEY (`voucherId`)
) ENGINE=InnoDB AUTO_INCREMENT=705651 DEFAULT CHARSET=latin1;

CREATE TABLE `voucher_account` (
  `id` double NOT NULL AUTO_INCREMENT,
  `voucherDebitCredit` int(11) NOT NULL DEFAULT '1' COMMENT '1=Debit, 2=Credit',
  `voucherAmount` double NOT NULL,
  `accountId` int(11) NOT NULL,
  `voucherId` double NOT NULL,
  `voucherMain` int(11) NOT NULL DEFAULT '0' COMMENT '1=Main Input',
  `counterAccountId` int(11) NOT NULL DEFAULT '0',
  `currencyRate` double NOT NULL DEFAULT '1',
  PRIMARY KEY (`id`),
  KEY `voucherId` (`voucherId`),
  KEY `accountId` (`accountId`),
  KEY `voucherDebitCredit` (`voucherDebitCredit`),
  CONSTRAINT `accountId` FOREIGN KEY (`accountId`) REFERENCES `account` (`accountId`),
  CONSTRAINT `voucher_account_ibfk_1` FOREIGN KEY (`voucherId`) REFERENCES `voucher` (`voucherId`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=1542890 DEFAULT CHARSET=latin1;

CREATE TABLE `wilayah` (
  `WilId` int(11) NOT NULL AUTO_INCREMENT,
  `WilName` varchar(50) DEFAULT NULL,
  `WilStatus` int(1) DEFAULT '0',
  `BranchId` int(10) unsigned DEFAULT NULL,
  PRIMARY KEY (`WilId`),
  KEY `WilId` (`WilId`),
  KEY `FK_branch` (`BranchId`),
  CONSTRAINT `FK_branch` FOREIGN KEY (`BranchId`) REFERENCES `branches` (`branchId`)
) ENGINE=InnoDB AUTO_INCREMENT=203 DEFAULT CHARSET=utf8;

