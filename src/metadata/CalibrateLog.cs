﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Landis.Library.Metadata;

namespace Landis.Extension.Succession.NECN
{
    public class CalibrateLog
    {

        public static int year, month, climateRegionIndex, cohortAge;
        public static double cohortWoodB, cohortLeafB;
        public static string speciesName;
        public static double mortalityAGEwood, mortalityAGEleaf;
        public static double availableWater;
        public static double actual_LAI, base_lai, seasonal_adjustment;
        public static double mineralNalloc, resorbedNalloc;
        public static double limitLAI, limitH20, limitT, limitN;
        public static double maxNPP, maxB, siteB, cohortB, soilTemp;
        public static double actualWoodNPP, actualLeafNPP;
        public static double mortalityBIOwood, mortalityBIOleaf;
        //    CalibrateLog.Write("NPPwood_C, NPPleaf_C, ");  //from ComputeNPPcarbon
        public static double resorbedNused, mineralNused, demand_N;

        public static void WriteLogFile()
        {
            Outputs.calibrateLog.Clear();
            CalibrateLog clog = new CalibrateLog();

            clog.Year = year;
            clog.Month = month;
            clog.ClimateRegionIndex = climateRegionIndex;
            clog.CohortAge = cohortAge;
            clog.CohortWoodBiomass = cohortWoodB;
            clog.CohortLeafBiomass = cohortLeafB;
            clog.SpeciesName = speciesName;
            clog.MortalityAGEwoodBiomass = mortalityAGEwood;
            clog.MortalityAGEleafBiomass = mortalityAGEleaf;
            clog.MortalityTHINwoodBiomass = mortalityBIOwood;
            clog.MortalityTHINleafBiomass = mortalityBIOleaf;
            clog.AvailableWater = availableWater;
            clog.LAI = actual_LAI;
            clog.BaseLAI = base_lai;
            clog.SeaonalAdjustLAI = seasonal_adjustment;
            clog.MineralNalloc = mineralNalloc;
            clog.ResorbedNalloc = resorbedNalloc;
            clog.MineralNconsumed = mineralNused;
            clog.ResorbedNconsumed = resorbedNused;
            clog.GrowthLimitLAI = limitLAI;
            clog.GrowthLimitN = limitN;
            clog.GrowthLimitSoilWater = limitH20;
            clog.GrowthLimitT = limitT;
            clog.MaximumANPP = maxNPP;
            clog.CohortMaximumBiomass = maxB;
            clog.TotalSiteBiomass = siteB;
            clog.CohortBiomass = cohortB;
            clog.SoilTemperature = soilTemp;
            clog.ActualWoodANPP = actualWoodNPP;
            clog.ActualLeafANPP = actualLeafNPP;
            clog.TotalNDemand = demand_N;


            Outputs.calibrateLog.AddObject(clog);
            Outputs.calibrateLog.WriteToFile();

        }

        //CalibrateLog.Write("Year, Month, ClimateRegionIndex, SpeciesName, CohortAge, CohortWoodB, CohortLeafB, ");  // from ComputeChange
        //    CalibrateLog.Write("MortalityAGEwood, MortalityAGEleaf, ");  // from ComputeAgeMortality
        //    CalibrateLog.Write("availableWater,");  //from Water_limit
        //    CalibrateLog.Write("LAI, tlai, rlai,");  // from ComputeChange
        //    CalibrateLog.Write("mineralNalloc, resorbedNalloc, ");  // from calculateN_Limit

        //    // These three together:
        //    CalibrateLog.Write("limitLAI, limitH20, limitT, limitN, ");  //from ComputeActualANPP
        //    CalibrateLog.Write("maxNPP, Bmax, Bsite, Bcohort, soilTemp, ");  //from ComputeActualANPP
        //    CalibrateLog.Write("actualWoodNPP, actualLeafNPP, ");  //from ComputeActualANPP

        //    CalibrateLog.Write("MortalityBIOwood, MortalityBIOleaf, ");  // from ComputeGrowthMortality
        //    CalibrateLog.Write("NPPwood_C, NPPleaf_C, ");  //from ComputeNPPcarbon
        //    CalibrateLog.Write("resorbedNused, mineralNused, Ndemand,");  // from AdjustAvailableN
        //    CalibrateLog.WriteLine("deltaWood, deltaLeaf, totalMortalityWood, totalMortalityLeaf");  // from ComputeChange

        [DataFieldAttribute(Unit = FieldUnits.Year, Desc = "Simulation Year")]
        public int Year {set; get;}

        // ********************************************************************
        [DataFieldAttribute(Unit = FieldUnits.Month, Desc = "Simulation Month")]
        public int Month { set; get; }
        // ********************************************************************
        [DataFieldAttribute(Unit = "Index", Desc = "Climate Region Index")]
        public int ClimateRegionIndex { set; get; }
        // ********************************************************************
        [DataFieldAttribute(Desc = "Species Name")]
        public string SpeciesName { set; get; }
        // ********************************************************************
        [DataFieldAttribute(Unit= FieldUnits.Year, Desc = "CohortAge")]
        public int CohortAge { set; get; }
        // ********************************************************************
        [DataFieldAttribute(Unit = FieldUnits.g_B_m2, Desc = "Cohort Wood Biomass", Format = "0.0")]
        public double CohortWoodBiomass { set; get; }
        // ********************************************************************
        [DataFieldAttribute(Unit = FieldUnits.g_B_m2, Desc = "Cohort Leaf Biomass", Format = "0.0")]
        public double CohortLeafBiomass { set; get; }
        // ********************************************************************
        [DataFieldAttribute(Unit = FieldUnits.g_B_m2, Desc = "Cohort Total Biomass", Format = "0.0")]
        public double CohortBiomass { set; get; }
        // ********************************************************************
        [DataFieldAttribute(Unit = FieldUnits.g_B_m2, Desc = "Mortality Age Wood Biomass", Format = "0.000")]
        public double MortalityAGEwoodBiomass { set; get; }
        // ********************************************************************
        [DataFieldAttribute(Unit = FieldUnits.g_B_m2, Desc = "Mortality Age Leaf Biomass", Format = "0.00000")]
        public double MortalityAGEleafBiomass { set; get; }
        // ********************************************************************
        [DataFieldAttribute(Unit = FieldUnits.g_B_m2, Desc = "Mortality Thinning Wood Biomass", Format = "0.000")]
        public double MortalityTHINwoodBiomass { set; get; }
        // ********************************************************************
        [DataFieldAttribute(Unit = FieldUnits.g_B_m2, Desc = "Mortality Thinning Leaf Biomass", Format = "0.00000")]
        public double MortalityTHINleafBiomass { set; get; }
        // ********************************************************************
        [DataFieldAttribute(Unit = "m2_m2", Desc = "Base LAI", Format = "0.0")]
        public double BaseLAI { set; get; }
        // ********************************************************************
        [DataFieldAttribute(Unit = "Fraction", Desc = "Seaonal LAI Adjust", Format = "0.00")]
        public double SeaonalAdjustLAI { set; get; }
        // ********************************************************************
        [DataFieldAttribute(Unit = "m2_m2", Desc = "Leaf Area Index", Format = "0.0")]
        public double LAI { set; get; }
        // ********************************************************************
        [DataFieldAttribute(Unit = "Fraction", Desc = "Growth Limit LAI", Format = "0.00")]
        public double GrowthLimitLAI { set; get; }
        // ********************************************************************
        [DataFieldAttribute(Unit = "Fraction", Desc = "Growth Limit Soil Water", Format = "0.00")]
        public double GrowthLimitSoilWater { set; get; }
        // ********************************************************************
        [DataFieldAttribute(Unit = "Fraction", Desc = "Growth Limit Temperature", Format = "0.00")]
        public double GrowthLimitT { set; get; }
        // ********************************************************************
        [DataFieldAttribute(Unit = "Fraction", Desc = "Growth Limit Nitrogen", Format = "0.00")]
        public double GrowthLimitN { set; get; }
        // ********************************************************************
        [DataFieldAttribute(Unit = FieldUnits.g_B_m2_yr1, Desc = "Maximum ANPP")]
        public double MaximumANPP { set; get; }
        // ********************************************************************
        [DataFieldAttribute(Unit = FieldUnits.g_B_m2_yr1, Desc = "Actual Wood ANPP", Format = "0.000")]
        public double ActualWoodANPP { set; get; }
        // ********************************************************************
        [DataFieldAttribute(Unit = FieldUnits.g_B_m2_yr1, Desc = "Actual Leaf ANPP", Format = "0.0000")]
        public double ActualLeafANPP { set; get; }
        // ********************************************************************
        [DataFieldAttribute(Unit = FieldUnits.g_B_m2, Desc = "Cohort Maximum Biomass")]
        public double CohortMaximumBiomass { set; get; }
        // ********************************************************************
        [DataFieldAttribute(Unit = FieldUnits.g_B_m2, Desc = "Total Site Biomass")]
        public double TotalSiteBiomass { set; get; }
        // ********************************************************************
        [DataFieldAttribute(Unit = FieldUnits.cm, Desc = "Available Water", Format = "0.0")]
        public double AvailableWater { set; get; }
        // ********************************************************************
        [DataFieldAttribute(Unit = FieldUnits.DegreeC, Desc = "Soil Temperature", Format = "0.0")]
        public double SoilTemperature { set; get; }
        // ********************************************************************
        [DataFieldAttribute(Unit = FieldUnits.g_N, Desc = "Mineral N Allocation", Format = "0.000")]
        public double MineralNalloc { set; get; }
        // ********************************************************************
        [DataFieldAttribute(Unit = FieldUnits.g_N, Desc = "Resorbed N Allocation", Format = "0.000")]
        public double ResorbedNalloc { set; get; }
        // ********************************************************************
        [DataFieldAttribute(Unit = FieldUnits.g_N, Desc = "Mineral N Consumed", Format = "0.000")]
        public double MineralNconsumed { set; get; }
        // ********************************************************************
        [DataFieldAttribute(Unit = FieldUnits.g_N, Desc = "Resorbed N Consumed", Format = "0.000")]
        public double ResorbedNconsumed { set; get; }
        // ********************************************************************
        [DataFieldAttribute(Unit = FieldUnits.g_N, Desc = "Total N Demand", Format = "0.000")]
        public double TotalNDemand { set; get; }

    }
}