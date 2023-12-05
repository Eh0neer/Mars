﻿using System.Collections.Generic;

namespace Mars.Interfaces;

// Интерфейс для сервиса управления сменами
public interface IShiftService
{
    List<Shift> ViewShifts();
    void CreateShift(Shift newShift);
}