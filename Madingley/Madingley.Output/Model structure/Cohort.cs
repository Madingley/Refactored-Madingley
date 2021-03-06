﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Madingley
{
    /// <summary>
    /// Class to hold properties of a single cohort
    /// </summary>
    public class Cohort
    {

        /// <summary>
        /// Time step when the cohort was generated
        /// </summary>
        private uint _BirthTimeStep;
        /// <summary>
        /// Get time step when the cohort was generated
        /// </summary>
        public uint BirthTimeStep { get { return _BirthTimeStep; } }

        /// <summary>
        /// The time step at which this cohort reached maturity
        /// </summary>
        private uint _MaturityTimeStep;
        /// <summary>
        /// Get and set the time step at which this cohort reached maturity
        /// </summary>
        public uint MaturityTimeStep { get { return _MaturityTimeStep; } set { _MaturityTimeStep = value; } }

        /// <summary>
        /// A list of all cohort IDs ever associated with individuals in this current cohort
        /// </summary>
        private List<UInt32> _CohortID = new List<UInt32>();
        /// <summary>
        /// Get the list of all cohort IDs ever associated with individuals in this current cohort
        /// </summary>
        public List<UInt32> CohortID { get { return _CohortID; } }

        /// <summary>
        /// The mean juvenile mass of individuals in this cohort
        /// </summary>
        private double _JuvenileMass;
        /// <summary>
        /// Get the mean juvenile mass of individuals in this cohort
        /// </summary>
        public double JuvenileMass { get { return _JuvenileMass; } }

        /// <summary>
        /// The mean mature adult mass of individuals in this cohort
        /// </summary>
        private double _AdultMass;
        /// <summary>
        /// Get the mean mature adult mass of individuals in this cohort
        /// </summary>
        public double AdultMass { get { return _AdultMass; } }

        /// <summary>
        /// The mean body mass of an individual in this cohort
        /// </summary>
        private double _IndividualBodyMass;
        /// <summary>
        /// Get or set the mean body mass of an individual in this cohort
        /// </summary>
        public double IndividualBodyMass
        {
            get { return _IndividualBodyMass; }
            set { _IndividualBodyMass = value; }
        }

        /// <summary>
        /// Individual biomass assigned to reproductive potential
        /// </summary>
        private double _IndividualReproductivePotentialMass;
        /// <summary>
        /// Get or set the individual biomass assigned to reproductive potential
        /// </summary>
        public double IndividualReproductivePotentialMass
        {
            get { return _IndividualReproductivePotentialMass; }
            set { _IndividualReproductivePotentialMass = value; }
        }

        /// <summary>
        /// The maximum mean body mass ever achieved by individuals in this cohort
        /// </summary>
        private double _MaximumAchievedBodyMass;
        /// <summary>
        /// Get or set the maximum mean body mass ever achieved by individuals in this cohort
        /// </summary>
        public double MaximumAchievedBodyMass
        {
            get { return _MaximumAchievedBodyMass; }
            set { _MaximumAchievedBodyMass = value; }
        }

        /// <summary>
        /// The number of individuals in the cohort
        /// </summary>
        private double _CohortAbundance;
        /// <summary>
        /// Get or set the number of individuals in the cohort
        /// </summary>
        public double CohortAbundance
        {
            get { return _CohortAbundance; }
            set { _CohortAbundance = value; }
        }

        /// <summary>
        /// The index of the functional group that the cohort belongs to
        /// </summary>
        private byte _FunctionalGroupIndex;
        /// <summary>
        /// Get the index of the functional group that the cohort belongs to
        /// </summary>
        public byte FunctionalGroupIndex { get { return _FunctionalGroupIndex; } }

        /// <summary>
        /// Whether this cohort has ever been merged with another cohort
        /// </summary>
        private Boolean _Merged;
        /// <summary>
        /// Get or set whether this cohort has ever been merged with another cohort
        /// </summary>
        public Boolean Merged
        {
            get { return _Merged; }
            set { _Merged = value; }
        }

        /// <summary>
        /// The proportion of the timestep for which this cohort is active
        /// </summary>
        private double _ProportionTimeActive;
        /// <summary>
        /// Get and set the proportion of time for which this cohort is active
        /// </summary>
        public double ProportionTimeActive
        {
            get { return _ProportionTimeActive; }
            set { _ProportionTimeActive = value; }
        }

        /// <summary>
        /// The trophic index for this cohort at this time
        /// </summary>
        private double _TrophicIndex;
        /// <summary>
        /// Get and set the trophic index
        /// </summary>
        public double TrophicIndex
        {
            get { return _TrophicIndex; }
            set { _TrophicIndex = value; }
        }

        /// <summary>
        /// The optimal prey body size for individuals in this cohort
        /// </summary>
        private double _LogOptimalPreyBodySizeRatio;
        /// <summary>
        /// Get and set the optimal prey body size for individuals in this cohort
        /// </summary>
        public double LogOptimalPreyBodySizeRatio
        {
            get { return _LogOptimalPreyBodySizeRatio; }
            set { _LogOptimalPreyBodySizeRatio = value; }
        }

        public Cohort(
            uint birthTimeStep,
            uint maturityTimeStep,
            List<UInt32> cohortID,
            double juvenileMass,
            double adultMass,
            double individualBodyMass,
            double individualReproductivePotentialMass,
            double maximumAchievedBodyMass,
            double cohortAbundance,
            byte functionalGroupIndex,
            Boolean merged,
            double proportionTimeActive,
            double trophicIndex,
            double logOptimalPreyBodySizeRatio)
        {
            this._BirthTimeStep = birthTimeStep;
            this._MaturityTimeStep = maturityTimeStep;
            this._CohortID = cohortID.ToList();
            this._JuvenileMass = juvenileMass;
            this._AdultMass = adultMass;
            this._IndividualBodyMass = individualBodyMass;
            this._IndividualReproductivePotentialMass = individualReproductivePotentialMass;
            this._MaximumAchievedBodyMass = maximumAchievedBodyMass;
            this._CohortAbundance = cohortAbundance;
            this._FunctionalGroupIndex = functionalGroupIndex;
            this._Merged = merged;
            this._ProportionTimeActive = proportionTimeActive;
            this._TrophicIndex = trophicIndex;
            this._LogOptimalPreyBodySizeRatio = logOptimalPreyBodySizeRatio;
        }
    }
}
