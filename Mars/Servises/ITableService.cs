﻿using System.Collections.Generic;

namespace Mars.Interfaces;

// Интерфейс для сервиса управления столиками
public interface ITableService
{
    List<Table> ViewAllTables();
    Table GetTableById(int tableId);
}