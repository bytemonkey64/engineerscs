﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engineers
{
    class Components
    {
        public Component AberrantShieldPatternAnalysis = new Component("Aberrant Shield Pattern Analysis", "Data", "Rare", "Ship Scanning");
        public Component AbnormalCompactEmissionData = new Component("Abnormal Compact Emission Data", "Data", "Very rare", "Ship Scanning, Signal Source");
        public Component AdaptiveEncryptorsCapture = new Component("Adaptive Encryptors Capture", "Data", "Very rare", "Mission Reward");
        public Component AnomalousBulkScanData = new Component("Anomalous Bulk Scan Data", "Data", "Very common", "Ship Scanning");
        public Component AnomalousFSDTelemetry = new Component("Anomalous FSD Telemetry", "Data", "Common", "High Wake Scanning");
        public Component Antimony = new Component("Antimony", "Raw material", "Rare", "Surface Prospecting");
        public Component Arsenic = new Component("Arsenic", "Raw material", "Common", "Surface Prospecting, Mining");
        public Component ArticulationMotors = new Component("Articulation Motors", "Commodity", "Standard", "Mission reward");
        public Component AtypicalDisruptedWakeEchoes = new Component("Atypical Disrupted Wake Echoes", "Data", "Very common", "High Wake Scanning");
        public Component AtypicalEncryptionArchives = new Component("Atypical Encryption Archives", "Data", "Rare", "Surface POI");
        public Component BasicConductors = new Component("Basic Conductors", "Manufactured", "Very common", "Signal Source");
        public Component BiotechConductors = new Component("Biotech Conductors", "Manufactured", "Very rare", "Mission Reward");
        public Component Bromellite = new Component("Bromellite", "Commodity", "Standard", "Mining");
        public Component Cadmium = new Component("Cadmium", "Raw material", "Rare", "Surface Prospecting");
        public Component Carbon = new Component("Carbon", "Raw material", "Very common", "Surface Prospecting, Mining (Ice rings)");
        public Component ChemicalDistillery = new Component("Chemical Distillery", "Manufactured", "Standard", "Ship Salvage (Transport ships)");
        public Component ChemicalManipulators = new Component("Chemical Manipulators", "Manufactured", "Rare", "Ship Salvage (Transport ships), Surface POI");
        public Component ChemicalProcessors = new Component("Chemical Processors", "Manufactured", "Common", "Ship Salvage (Transport ships), Signal Source");
        public Component ChemicalStorageUnits = new Component("Chemical Storage Units", "Manufactured", "Very common", "Ship Salvage (Transport ships)");
        public Component Chromium = new Component("Chromium", "Raw material", "Common", "Surface Prospecting, Mining (Ice rings)");
        public Component ClassifiedScanDatabanks = new Component("Classified Scan Databanks", "Data", "Standard", "Ship Scanning");
        public Component ClassifiedScanFragment = new Component("Classified Scan Fragment", "Data", "Very rare", "Surface Data Point");
        public Component CMMComposite = new Component("CMM Composite", "Commodity", "Standard", "Markets");
        public Component CompactComposites = new Component("Compact Composites", "Manufactured", "Very common", "Signal Source, Surface POI");
        public Component CompoundShielding = new Component("Compound Shielding", "Manufactured", "Rare", "Ship Salvage (Combat ships), Signal Source");
        public Component ConductiveCeramics = new Component("Conductive Ceramics", "Manufactured", "Standard", "Ship Salvage (Transport ships)");
        public Component ConductiveComponents = new Component("Conductive Components", "Manufactured", "Common", "Ship Salvage (Transport ships), Signal Source");
        public Component ConductivePolymers = new Component("Conductive Polymers", "Manufactured", "Rare", "Ship Salvage (Transport ships)");
        public Component ConfigurableComponents = new Component("Configurable Components", "Manufactured", "Rare", "");
        public Component CoreDynamicsComposites = new Component("Core Dynamics Composites", "Manufactured", "Very rare", "Ship Salvage (Combat ships)");
        public Component CrackedIndustrialFirmware = new Component("Cracked Industrial Firmware", "Data", "Standard", "Surface Data Point, Mission Reward");
        public Component CrystalShards = new Component("Crystal Shards", "Manufactured", "Very common", "Ship Salvage (Combat ships), Surface POI");
        public Component DataminedWakeExceptions = new Component("Datamined Wake Exceptions", "Data", "Very rare", "High Wake Scanning");
        public Component DecodedEmissionData = new Component("Decoded Emission Data", "Data", "Rare", "Ship Scanning");
        public Component DistortedShieldCycleRecordings = new Component("Distorted Shield Cycle Recordings", "Data", "Very common", "Ship Scanning (Transport ships)");
        public Component DivergentScanData = new Component("Divergent Scan Data", "Data", "Rare", "Surface Data Point");
        public Component EccentricHyperspaceTrajectories = new Component("Eccentric Hyperspace Trajectories", "Data", "Rare", "Signal Source");
        public Component ElectrochemicalArrays = new Component("Electrochemical Arrays", "Manufactured", "Standard", "Ship Salvage (Military & Authority ships), Signal Source");
        public Component EmergencyPowerCells = new Component("Emergency Power Cells", "Commodity", "Standard", "Markets near Akhenaten (High Tech/Refinery)");
        public Component EnergyGridAssembly = new Component("Energy Grid Assembly", "Commodity", "Standard", "Markets near Stafkarl (Industrial/Refinery)");
        public Component ExceptionalScrambledEmissionData = new Component("Exceptional Scrambled Emission Data", "Data", "Very common", "Ship Scanning, Signal Source");
        public Component ExhaustManifold = new Component("Exhaust Manifold", "Commodity", "Standard", "Markets near Run (Industrial/Refinery)");
        public Component ExquisiteFocusCrystals = new Component("Exquisite Focus Crystals", "Manufactured", "Very rare", "Ship Salvage (Combat ships)");
        public Component FilamentComposites = new Component("Filament Composites", "Manufactured", "Common", "Ship Salvage (Military & Authority ships), Signal Source");
        public Component FlawedFocusCrystals = new Component("Flawed Focus Crystals", "Manufactured", "Common", "Signal Source");
        public Component FocusCrystals = new Component("Focus Crystals", "Manufactured", "Standard", "Ship Salvage (Combat ships), Signal Source");
        public Component GalvanisingAlloys = new Component("Galvanising Alloys", "Manufactured", "Common", "Ship Salvage (Combat ships)");
        public Component Germanium = new Component("Germanium", "Raw material", "Common", "Surface Prospecting, Mining");
        public Component GridResistors = new Component("Grid Resistors", "Manufactured", "Very common", "Ship Salvage (Military & Authority ships), Signal Source");
        public Component HardwareDiagnosticSensor = new Component("Hardware Diagnostic Sensor", "Commodity", "Standard", "Markets near Lei Jing (High Tech/Refinery)");
        public Component HeatConductionWiring = new Component("Heat Conduction Wiring", "Manufactured", "Very common", "Ship Salvage (Transport ships), Signal Source");
        public Component HeatConductors = new Component("Heat Conductors", "Manufactured", "Standard", "Ship Salvage (Transport ships)");
        public Component HeatDispersionPlate = new Component("Heat Dispersion Plate", "Manufactured", "Common", "Ship Salvage (Transport ships), Signal Source");
        public Component HeatExchangers = new Component("Heat Exchangers", "Manufactured", "Standard", "Ship Salvage (Transport ships), Signal Source");
        public Component HeatResistantCeramics = new Component("Heat Resistant Ceramics", "Manufactured", "Common", "Ship Salvage (Transport ships)");
        public Component HeatVanes = new Component("Heat Vanes", "Manufactured", "Rare", "Ship Salvage (Transport ships), Signal Source");
        public Component HeatsinkInterlink = new Component("Heatsink Interlink", "Commodity", "Standard", "Markets near Myrbat (Industrial/Refinery)");
        public Component HighDensityComposites = new Component("High Density Composites", "Manufactured", "Standard", "Ship Salvage (Military & Authority ships), Signal Source");
        public Component HNShockMount = new Component("HN Shock Mount", "Commodity", "Standard", "Markets");
        public Component HybridCapacitors = new Component("Hybrid Capacitors", "Manufactured", "Common", "Ship Salvage (Military & Authority ships), Signal Source");
        public Component ImperialShielding = new Component("Imperial Shielding", "Manufactured", "Very rare", "Signal Source (Imperial systems)");
        public Component ImprovisedComponents = new Component("Improvised Components", "Manufactured", "Very rare", "Systems in civil unrest");
        public Component InconsistentShieldSoakAnalysis = new Component("Inconsistent Shield Soak Analysis", "Data", "Common", "Ship Scanning (Transport ships)");
        public Component InsulatingMembrane = new Component("Insulating Membrane", "Commodity", "Standard", "Markets");
        public Component IonDistributor = new Component("Ion Distributor", "Commodity", "Standard", "Markets near 70 Tauri (Industrial/Extraction)");
        public Component Iron = new Component("Iron", "Raw material", "Very common", "Surface Prospecting, Mining (Ice rings)");
        public Component IrregularEmissionData = new Component("Irregular Emission Data", "Data", "Common", "Mission Reward, Signal Source");
        public Component MagneticEmitterCoil = new Component("Magnetic Emitter Coil", "Commodity", "Standard", "Markets near Leesti (Industrial/Refinery)");
        public Component Manganese = new Component("Manganese", "Raw material", "Common", "Surface Prospecting, Mining");
        public Component MechanicalComponents = new Component("Mechanical Components", "Manufactured", "Standard", "Ship Salvage (Transport ships), Signal Source");
        public Component MechanicalEquipment = new Component("Mechanical Equipment", "Manufactured", "Common", "Ship Salvage (Transport ships), Signal Source");
        public Component MechanicalScrap = new Component("Mechanical Scrap", "Manufactured", "Very common", "Ship Salvage (Transport ships)");
        public Component Mercury = new Component("Mercury", "Raw material", "Standard", "Surface Prospecting");
        public Component MicroControllers = new Component("Micro Controllers", "Commodity", "Standard", "Markets");
        public Component MicroWeaveCoolingHoses = new Component("Micro-Weave Cooling Hoses","Commodity","Standard","Mission reward");
        public Component MilitaryGradeAlloys = new Component("Military Grade Alloys", "Manufactured", "Very rare", "Ship Salvage (Military & Authority ships), Mission Reward");
        public Component MilitarySupercapacitors = new Component("Military Supercapacitors", "Manufactured", "Very rare", "Systems in war");
        public Component ModifiedConsumerFirmware = new Component("Modified Consumer Firmware", "Data", "Common", "Mission Reward, Signal Source");
        public Component ModifiedEmbeddedFirmware = new Component("Modified Embedded Firmware", "Data", "Very rare", "Surface Data Point");
        public Component ModularTerminals = new Component("Modular Terminals", "Commodity", "Standard", "Mission reward");
        public Component Molybdenum = new Component("Molybdenum", "Raw material", "Standard", "Surface Prospecting");
        public Component Nanobreakers = new Component("Nanobreakers", "Commodity", "Standard", "Mission reward");
        public Component NeofabricInsulation = new Component("Neofabric Insulation", "Commodity", "Standard", "Mission reward");
        public Component Nickel = new Component("Nickel", "Raw material", "Very common", "Surface Prospecting, Mining (Ice rings)");
        public Component Niobium = new Component("Niobium", "Raw material", "Standard", "Surface Prospecting, Mining");
        public Component OpenSymmetricKeys = new Component("Open Symmetric Keys", "Data", "Standard", "Surface Data Point, Signal Source");
        public Component Osmium = new Component("Osmium", "Commodity", "Standard", "Mining");
        public Component PeculiarShieldFrequencyData = new Component("Peculiar Shield Frequency Data", "Data", "Very rare", "Ship Scanning");
        public Component PharmaceuticalIsolators = new Component("Pharmaceutical Isolators", "Manufactured", "Very rare", "");
        public Component PhaseAlloys = new Component("Phase Alloys", "Manufactured", "Standard", "Ship Salvage (Combat ships)");
        public Component Phosphorus = new Component("Phosphorus", "Raw material", "Very common", "Surface Prospecting, Mining (Ice rings)");
        public Component Platinum = new Component("Platinum", "Commodity", "Standard", "Mining");
        public Component Polonium = new Component("Polonium", "Raw material", "Rare", "Surface Prospecting");
        public Component PolymerCapacitors = new Component("Polymer Capacitors", "Manufactured", "Rare", "Ship Salvage (Military & Authority ships), Signal Source");
        public Component PowerConverter = new Component("Power Converter", "Commodity", "Standard", "Markets near Lakota (Industrial/Extraction)");
        public Component PowerTransferBus = new Component("Power Transfer Bus", "Commodity", "Standard", "Markets near Cilbien Zu (Industrial/Extraction)");
        public Component Praseodymium = new Component("Praseodymium", "Commodity", "Standard", "Mining");
        public Component PrecipitatedAlloys = new Component("Precipitated Alloys", "Manufactured", "Standard", "Ship Salvage (Military & Authority ships)");
        public Component ProprietaryComposites = new Component("Proprietary Composites", "Manufactured", "Rare", "Signal Source (Federal systems)");
        public Component ProtoHeatRadiators = new Component("Proto Heat Radiators", "Manufactured", "Very rare", "Systems in economic boom, Signal Source");
        public Component ProtoLightAlloys = new Component("Proto Light Alloys", "Manufactured", "Rare", "Systems in economic boom, Signal Source");
        public Component ProtoRadiolicAlloys = new Component("Proto Radiolic Alloys", "Manufactured", "Very rare", "Systems in economic boom, Signal Source");
        public Component RadiationBaffle = new Component("Radiation Baffle", "Commodity", "Standard", "Markets near Heget (Industrial/Extraction)");
        public Component RefinedFocusCrystals = new Component("Refined Focus Crystals", "Manufactured", "Rare", "Mission Reward, Signal Source");
        public Component ReinforcedMountingPlate = new Component("Reinforced Mounting Plate", "Commodity", "Standard", "Markets near Eurybia (Extraction/Refinery)");
        public Component Ruthenium = new Component("Ruthenium", "Raw material", "Rare", "Surface Prospecting");
        public Component SalvagedAlloys = new Component("Salvaged Alloys", "Manufactured", "Very common", "Ship Salvage (Combat ships)");
        public Component Samarium = new Component("Samarium", "Commodity", "Standard", "Mining");
        public Component SecurityFirmwarePatch = new Component("Security Firmware Patch", "Data", "Rare", "Surface Data Point");
        public Component Selenium = new Component("Selenium", "Raw material", "Common", "Surface Prospecting, Mining");
        public Component ShieldEmitters = new Component("Shield Emitters", "Manufactured", "Common", "Ship Salvage (Combat ships), Signal Source");
        public Component ShieldingSensors = new Component("Shielding Sensors", "Manufactured", "Standard", "Ship Salvage (Combat ships), Signal Source");
        public Component SpecialisedLegacyFirmware = new Component("Specialised Legacy Firmware", "Data", "Very common", "Mission Reward, Signal Source");
        public Component StrangeWakeSolutions = new Component("Strange Wake Solutions", "Data", "Standard", "High Wake Scanning");
        public Component Sulphur = new Component("Sulphur", "Raw material", "Very common", "Surface Prospecting, Mining (Ice rings)");
        public Component TaggedEncryptionCodes = new Component("Tagged Encryption Codes", "Data", "Common", "Surface Data Point");
        public Component Technetium = new Component("Technetium", "Raw material", "Rare", "Surface Prospecting");
        public Component TelemetrySuite = new Component("Telemetry Suite", "Commodity", "Standard", "Mission reward");
        public Component Tellurium = new Component("Tellurium", "Raw material", "Rare", "Surface Prospecting");
        public Component TemperedAlloys = new Component("Tempered Alloys", "Manufactured", "Very common", "Ship Salvage (Combat ships)");
        public Component ThermicAlloys = new Component("Thermic Alloys", "Manufactured", "Rare", "Ship Salvage (Combat ships)");
        public Component Tin = new Component("Tin", "Raw material", "Standard", "Surface Prospecting");
        public Component Tungsten = new Component("Tungsten", "Raw material", "Standard", "Surface Prospecting, Mining");
        public Component UnexpectedEmissionData = new Component("Unexpected Emission Data", "Data", "Standard", "Ship Scanning (Combat ships), Signal Source");
        public Component UnidentifiedScanArchives = new Component("Unidentified Scan Archives", "Data", "Common", "Ship Scanning (Transport ships)");
        public Component UnknownFragment = new Component("Unknown Fragment", "Manufactured", "Very rare", "Destroyed Unknown Artefact");
        public Component UntypicalShieldScans = new Component("Untypical Shield Scans", "Data", "Standard", "Ship Scanning");
        public Component UnusualEncryptedFiles = new Component("Unusual Encrypted Files", "Data", "Very common", "Surface Data Point");
        public Component Vanadium = new Component("Vanadium", "Raw material", "Common", "Surface Prospecting, Mining (Ice rings)");
        public Component WornShieldEmitters = new Component("Worn Shield Emitters", "Manufactured", "Very common", "Ship Salvage (Combat ships)");
        public Component Yttrium = new Component("Yttrium", "Raw material", "Rare", "Surface Prospecting");
        public Component Zinc = new Component("Zinc", "Raw material", "Common", "Surface Prospecting, Mining");
        public Component Zirconium = new Component("Zirconium", "Raw material", "Common", "Surface Prospecting, Mining");

    }
}