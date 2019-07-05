﻿using System;

namespace EySpy
{
    public static class ActivateSpy
    {
        public static void StartSpy()
        {
            while (true)
            {
                SpyService.CheckActiveWindow();
            }
        }
    }
}