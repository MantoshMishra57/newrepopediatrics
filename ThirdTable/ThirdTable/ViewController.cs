using System;
using UIKit;
using System.Collections.Generic;
using System.Drawing;
using Foundation;

namespace ThirdTable
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}
		private UITableView tableView;
		private List <string>pediometricImageList;
		private List <string>pediometricLargeImageList;
		private List <string> colorList;
		private List <string>pediometricDiseaseDiscription;
		private List <string>pediometricDiseaseName;
		private List <string>testList;
		private List <string>testDescription;

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			UIBarButtonItem.Appearance.SetBackButtonTitlePositionAdjustment(new UIOffset(0, -60), UIBarMetrics.Default);
			this.Title = "Illustrative Neonatology by Satyan";
			this.NavigationController.NavigationBar.BarTintColor = UIColor.FromRGBA(24,94,200,1);
			this.NavigationController.NavigationBar.TitleTextAttributes = new UIStringAttributes()
			{
				ForegroundColor = UIColor.White
			};
			colorList = new List<string> () {
				"#FE982A","#7B9927","#1B304B","#B33D89"
			};
	
			pediometricImageList = new List<string> () {
				"Adaptive-Maternal-Changes-During-Pregnancy-300.png",
				"Biophysical-Profile300.png",
				"Placental-Abruption-Premature-300px-by-300px.png",
				"Placenta-Previa300.png",
				"Abnormal-Placental-Adherence300.png",
				"Chorionic-Villus-Sampling300.png",
				"Vasa-Previa300.png",
				"BdpSmall.png","PneumomediastinumSmall.png",
				"RDSSmall.png","Scimitar-syndromeSmall.png",
				"Bronchogenic-cystSmall.png","ThoraxSmall.png",
				"Pneumopericardium Small.png","PneumothoraxSmall.png",
				"Sequestration---intralobarSmall.png",
				"Sequestration--extralobarSmall.png","Type1CPAM300by300.png","Atlas-1.-Prematurity---early-and-late-complications300by300.png"
			};

//			pediometricLargeImageList = new List<string> () {
//				"Adaptive-Maternal-Changes-During-Pregnancy-400.png",
//				"Biophysical-Profile400.png",
//				"Placental-Abruption-Premature-400px-by-400px.png",
//				"Placenta-Previa400.png",
//				"Abnormal-Placental-Adherence400.png",
//				"Chorionic-Villus-Sampling400.png",
//				"Vasa-Previa400.png",
//				"Bdp.png","Pneumomediastinum.png",
//				"RDS.png","Scimitar-syndrome.png",
//				"Bronchogenic-cyst.png","Thorax.png",
//				"Pneumopericardium.png","Pneumothorax.png",
//				"Sequestration---intralobar.png",
//				"Sequestration--extralobar.png","Type1CPAM400by400.png"
//			};
			pediometricLargeImageList = new List<string> () {
				"Atlas-2.-Pregnancy-changesHRI..png",
				"BPP-copyHRI..png",
				"abruptionHRI.png",
				"Placenta-previaHRI..png",
				"Placental-adherenceHRI..png",
				"Chorionic-villus-samplingHRI..png",
				"Vasa-previaHRI..png",
				"BpdHRI..png","Pneumomediastinum-lat-view-copyHRI..png",
				"RDSHRI..png","Scimitar-syndromeHRI..png",
				"Bronchogenic-cystHRI..png","ThoraxHRI..png",
				"PneumopericardiumHRI..png","PneumothoraxHRI..png",
				"Sequestration---intralobarHRI..png",
				"Sequestration--extralobarHRI..png","CPAM-alternateHRI..png",
				"Atlas-1.-Prematurity---early-and-late-complicationsby750by540.png"
			};
			pediometricDiseaseName = new List<string> () 
			{
				"Maternal Changes During Pregnancy",
				"Biophysical Profile (BPP)",
				"Placental abruption",
				"Placenta previa",
				"Abnormal Placental Adherence",
				"Chorionic villus sampling"
				,"Vasa previa",
				"Bronchopulmonary dysplasia",
				"Pneumomedaistinum",
				"Respiratory Distress Syndrome"
				,"Scimitar Syndrome",
				"Bronchogenic Cyst"
				,"Thorax",
				"Pneumopericardium",
				"Pneumothorax",
				"Intralobar Bronchopulmonary Sequestration",
				"Extralobar Bronchopulmonary Sequestration","Type 1 CPAM","Prematurity"
			};

			pediometricDiseaseDiscription = new List<string>()
			{
				"The pregnant woman undergoes profound anatomic and physiologic changes in almost every organ system to accommodate the needs of the maternal-fetal unit." +
				" \nCardiovascular: Increased Heart Rate by 10-15bpm, increased blood volume (both plasma volume and RBC), increased cardiac output and decrease in BP with widened pulse pressure." +
				"\nRespiratory: Chronic hyperventilated state with increase in tidal volume and minute ventilation.\nRenal: Renal hypertrophy with increased renal blood flow and Glomerular Filtration Rate." +
				"\nHematology: Increase in RBC’s, WBC’s and coagulation factors. " +
				"Low hematocrit due to dilutional effect of increased plasma volume." +
				"\nGI: Constipation, hemorrhoids due to gravid uterus and gallstones.Endocrine: " +
				"Enlarged pituitary with increase in prolactin. Increased thyroid binding globulin, total T4, PTH, calcitriol and insulin."
				,"The Biophysical profile (BPP) is a noninvasive procedure for evaluating the fetus for signs of compromise." +
				" Ultrasound is used to assess four discrete biophysical parameters: fetal breathing, amniotic fluid volume, fetal tone and fetal movement." +
				" A separate nonstress test of the fetal heart rate can also be performed. " +
				"Each of the four ultrasound parameters and the nonstress test are given a score of 0 or 2 points." +
				"A total score ≥8 implies absence of significant central nervous system\u00a0hypoxemia/acidemia\u00a0at the time of testing." +
				" A score ≤4 can be a sign of fetal compromise."
				,"Placental abruption refers to bleeding at the decidual-placental interface that causes partial or total placental detachment prior to delivery of the fetus that is more than 20 weeks of gestation. It complicates complicates 0.2 to 1 percent of pregnancies. Risk factors include maternal hypertension, advanced maternal age, increased parity, smoking, cocaine, increased thrombotic state, trauma and uterine leiomyoma. The major clinical findings are vaginal bleeding and abdominal pain, often accompanied by hypertonic uterine contractions, uterine tenderness, and a nonreassuring fetal heart rate pattern. The diagnosis is primarily clinical. A retroplacental clot is the classic ultrasound finding of placental abruption, but is not always present. When placental separation exceeds 50 percent, acute disseminated intravascular coagulation and fetal death are common." +
				" Women with placental abruption are at several-fold higher risk of abruption in a subsequent pregnancy."
				,"Placenta previa refers to the presence of placental tissue that extends over the internal cervical os. " +
				"Incidence ranges from 3.5 to 4.6 per 1000 births." +
				" It can be complete or total, partial, marginal and low lying." +
				" It should be suspected in any woman beyond 20 weeks of gestation who presents with painless vaginal bleeding." +
				" The pathogenesis of placenta previa is unknown, possibly presence of areas of suboptimal endometrium in the upper uterine cavity due to previous surgery or pregnancies promotes implantation towards the lower uterine cavity. " +
				"Placenta previa is an indication for C-section."
				,"Abnormal adherent placenta is a general term that includes placenta accreta, increta, and percreta." +
				" \u00a0\nPlacenta accreta refers to an abnormality of placental implantation in which the anchoring placental villi attach to myometrium rather than decidua, resulting in a morbidly adherent placenta. " +
				"It is most common and accounts for 79%. " +
				"\nPlacenta increta: The chorionic villi penetrate into the myometrium and accounts for 14%.\nPlacenta percreta: The chorionic villi penetrate through the myometrium to the uterine serosa or adjacent organs.\nThe pathogenesis of all 3 is primarily attributed to defective decidualization of the implantation site. It may lead to severe hemorrhage, uterine perforation and infection." +
				" Management includes blood transfusion and prompt hysterectomy in case of extensive hemorrhage."
				,"Chorionic Villous Sampling (CVS) is an ambulatory procedure performed under real-time ultrasound guidance, usually between 10 and 13 weeks of gestation. There is a risk of limb-reduction defects if done earlier and amniocentesis is preferred at gestations ≥15 weeks due to ease of performing and avoiding diagnostic uncertainty related to confined placental mosaicism.\u00a0Based on operator preference and placental location CVS can be obtained transabdominally or transcervically. Rapid karyotyping can be achieved within 2 to 48 hours of sampling by direct examination of cytotrophoblast. " +
				"However, due to the risk of false positive results, " +
				"long-term (one week) cultures of mesenchymal cells should be performed concurrently as these cells better reflect fetal, " +
				"rather than the placental, genotype. " +
				"Risk factors include fetal loss, approximately 1.5% above baseline, increased risk of infection, premature rupture of membranes, " +
				"placental disruption and Rh sensitization."
				,"Vasa previa is present when unprotected fetal vessels traverse the fetal membranes over the internal cervical os. " +
				"It is seen with velamentous insertion of the umbilical cord, accessory placental lobes (succenturiate or bilobate placenta), multiple gestation and IVF pregnancy. " +
				"The prenatal diagnosis of vasa previa is based upon characteristic sonographic findings - membranous vessels that cross the internal cervical os." +
				" The classic triad of vasa previa is membrane rupture, painless vaginal bleeding and fetal bradycardia or fetal death. " +
				"\u00a0Elective cesarean delivery at after 35 weeks is recommended.\u00a0"
				,"Bronchopulmonary dysplasia (BPD) also known as chronic lung disease is thought to be secondary to airway injury, inflammation, and parenchymal fibrosis due to mechanical ventilation and oxygen toxicity in premature infant with immature lungs." +
				" Recently, in surfactant-treated extremely low birth weight (ELBW) infants, the characteristic pathologic finding of bronchopulmonary dysplasia (BPD) is disruption of lung development, referred to as the \"new\" BPD." +
				" In these patients, decreased septation and alveolar hypoplasia lead to fewer and larger alveoli with a reduction in the surface area available for gas exchange. " +
				"There is also dysregulation of pulmonary vasculature development. Maternal smoking or use of illicit drugs, maternal malnutrition, and infections in the mother during the pregnancy may affect the normal growth of the fetus, and may lead to premature labor, development of respiratory distress syndrome, and eventually to BPD." +
				" Male infants are more likely to be born prematurely and to develop BPD. Degree of prematurity, prolonged mechanical ventilation, high concentrations of oxygen, presence of PDA all are risk factors for BPD." +
				" The chest x ray shows evidence of interstitial fibrosis, cystic changes and areas of hyperinflation." +
				" These infants often need supplemental oxygen and have feeding intolerance.Severe Bronchopulmonary dysplasia with pulmonary arterial hypertensionAs described previously, bronchopulmonary dysplasia (BPD) is associated with multiple risk factors, including prematurity, mechanical ventilation, oxygen toxicity, sepsis, and patent ductus arteriosus." +
				" Some of the complications of BPD include pulmonary arterial hypertension (PH), tracheostomy and feeding intolerance. Pulmonary artery hypertension (PH) is increasingly recognized as an important complication associated with BPD. " +
				" Early disruption of airway development long with dysregulated pulmonary vasculature is thought to be the pathogenesis. " +
				"Not all infants with severe BPD have PH. PH often leads to right ventricular dilatation and failure which is known as ‘Cor Pulmonale’. " +
				"In addition to ongoing lung injury, prolonged ventilation and intubation may be associated with acquired subglottic stenosis and laryngeal injury, especially in infants who require multiple intubations." +
				" These infants often need tracheostomy. Gastroesophageal reflux is a common complication of prematurity and can often complicate BPD secondary to chronic aspiration. " +
				"These infants often need post gastric tube feeding."
				,"Pneumomediastinum consists of air in the mediastinal space. Most cases of are asymptomatic. Large collections of air may result in tachypnea, cyanosis and muffled heart sounds without a shift. The diagnosis is made on a chest radiograph." +
					" If the amount of air is large, the pneumomediastinum can usually be appreciated on an anteroposterior view as a halo of air around the heart, or on a lateral view as a retrosternal or superior mediastinal radiolucency. The air in the mediastinum surrounds the thymus and lifts it from the cardiac shadow, resulting in the characteristic \"spinnaker sail\" sign." +
				" It usually resolves spontaneously, and requires no specific treatment. The patient should be observed closely for evidence of cardio-respiratory compromise and development of other air leaks, especially pneumothorax. " +
				"Infants with tension pneumomediastinum should be treated emergently with ultrasound-guided percutaneous drainage."
				,"Also known as Hyaline membrane Disease (HMD). " +
				"The primary abnormality in RDS is surfactant deficiency. With inadequate surfactant activity, the resultant higher surface tension leads to instability of the lung at end-expiration, low lung volume, decreased functional residual capacity (FRC) and decreased compliance. These changes in lung function cause hypoxemia primarily due to a mismatch between ventilation and perfusion due to collapse of large portions of the lung (atelectasis) as well as intrapulmonary and extrapulmonary right-to-left shunts. Risk factors include prematurity, maternal diabetes, male sex and perinatal depression. Neonate presents with grunting, flaring, retractions, tachypnea and cyanosis. Chest X-ray shows low lung volumes with diffuse ground-glass appearance and air bronchograms." +
				" Management involves respiratory support, surfactant administration and oxygen supplementation"
				,"Scimitar syndrome is a variant Partial Anomalous Pulmonary Venous Return in which part or even the entire right lung is drained by right pulmonary veins that connect anomalously to the inferior vena cava. The affected lung and its associated airways, which are drained by the scimitar vein, are often hypoplastic or have unusual bronchial or vascular distribution patterns. Sequestration as well as aortopulmonary collateral vessels may also involve the affected lung." +
				" A chest radiograph may show the shadow of these veins as they course and coalesce towards the diaphragm and the inferior vena cava (IVC), giving the characteristic \"scimitar\" appearance. Infants with scimitar syndrome who are symptomatic at an early age probably have pulmonary hypertension or congestive heart failure and require intervention to prevent irreversible pulmonary vascular disease or death. " +
				"Surgery is the definitive treatment.","Bronchogenic cysts arise from anomalous budding of the foregut during development and represent part of the spectrum of bronchopulmonary foregut malformations. " +
				"Cystic masses can be air filled (communicates with airway) or solid. Majority are posterior to trachea. " +
				"Affected patients typically present during the second decade of life with recurrent coughing, wheezing (which may simulate asthma), and pneumonia, but they may become symptomatic in infancy or adulthood. Newborns with rapidly enlarging central cysts can develop respiratory distress, cyanosis, and feeding difficulty. Bronchogenic cysts appear on chest radiograph as round water-density masses that may have air-fluid levels." +
				" The management of a bronchogenic cyst consists of surgical excision by partial or total lobectomy. "
				," Chest X-ray – Diagrammatic Representation of Thoracic Structures. The chest x-ray is one of the most frequently requested radiological examinations in neonatal intensive care units (ICU), representing an essential tool in the diagnosis of pulmonary diseases in preterm and term neonates. Chest x-ray also allows the evaluation of nasogastric probes, endotracheal tubes, arterial and venous umbilical catheters positioning. The lungs, heart, thymus are the major organs visualized in this diagram. Air filled lung, typically appears dark. Characteristic appearance such as ground glass appearance in RDS, interstitial lines with small effusions in TTN, patchy airspace with areas of hyperinflation in meconium aspiration are helpful radiological diagnosis. The thymus is radiologically characterized by a widening of the upper mediastinum, above the cardiac image, on the frontal view. The cardiac silhouette can be visualized below the thymus and can be seen resting on the diaphragm. The diaphragm separates the thorax from the abdomen. " +
				"The CXR shows the endotracheal tube in the airway just below the clavicles. The external hardware (chest lead) is also visualized.","Pneumopericardium is a rare condition caused by air in the pericardial space. It can sometimes lead to cardiac tamponade that is life-threatening." +
				" It occurs in a mechanically ventilated infant which may cause air to dissect in the pericardial sac. " +
				"Neonate presents with cyanosis, muffled heart sounds, hypotension, bradycardia and increased respiratory distress\nThe typical presentation is the abrupt onset of hemodynamic compromise due to cardiac tamponade. " +
				"Acute collapse may be preceded by tachycardia and a narrowed pulse pressure. " +
				"Findings on physical examination include bradycardia, hypotension, increased respiratory distress, and cyanosis. " +
				"The chest x-ray (AP view) shows air surrounding the heart shadow within the pericardium." +
				" Air under the inferior surface of the heart is diagnostic. " +
				"Symptomatic infants require pericardial drainage. "
				,"Pneumothorax consists of air in the space between the parietal and visceral pleura." +
				  " Pneumothorax should be suspected in any newborn with the sudden onset of respiratory distress." +
				  " The level of suspicion should be high in a mechanically ventilated infant with an unexplained deterioration in oxygenation, ventilation, or cardiovascular status. " +
				  " Risk factors are parenchymal lung disease like meconium aspiration syndrome and respiratory distress syndrome, pulmonary hypoplasia, pneumonia, high ventilator pressures etc, Neonate presents with respiratory distress, cyanosis, and bradycardia with decreased breath sounds on the affected side." +
				  " Characteristic findings on chest x-ray (AP view) include air in the pleural space outlining the visceral pleura, atelectasis with flattening of the diaphragm on the affected side, and shift of the mediastinum away from the pneumothorax. " +
				   "May require needle aspiration and chest tube if continuous leak."
				,"Bronchopulmonary sequestration (BPS) is a rare congenital malformation of the lower respiratory tract. " +
					"It consists of a nonfunctioning mass of lung tissue that lacks normal communication with the tracheobronchial tree and receives its arterial blood supply from the systemic circulation." +
				" Sequestrations are classified anatomically as ‘Intralobar’ and ‘Extralobar’.\nIntralobar sequestration is the most common form, consisting of approximately 75% of sequestrations and usually presents in adolescence with recurrent pneumonias." +
				" It typically nvolves lower lobes (L>R) and lacks its own visceral pleura. Chest x-ray shows unilateral, uniformly dense lung mass, often triangular or oval. " +
				"Management includes lobectomy."
				,"Bronchopulmonary sequestration (BPS) is a rare congenital malformation of the lower respiratory tract. " +
				"It consists of a nonfunctioning mass of lung tissue that lacks normal communication with the tracheobronchial tree and receives its arterial blood supply from the systemic circulation." +
				" Sequestrations are classified anatomically as ‘Intralobar’ and ‘Extralobar’. \u00a0\nExtralobar sequestration consist of approximately 25% of sequestrations, more commonly presents in the fetal and neonatal period and is more prevalent in males (3:1)." +
				" The lesion has its own visceral pleura. There is 40-60% risk of other anomalies like congenital diaphragmatic hernia, vertebral anomalies, congenital heart disease, pulmonary hypoplasia, colonic duplication, CCAM etc. " +
				"Chest x-ray shows unilateral, uniformly dense lung mass, often triangular or oval. Usually manage nonoperatively.","Congenital pulmonary airway malformations (CPAM)\u00a0are multicystic masses of segmental lung tissue with abnormal bronchial proliferation. CPAMs are considered part of the spectrum of bronchopulmonary\u00a0foregut malformations. Although rare, it is the most common congenital lung lesion. The widespread use of antenatal ultrasound examination has resulted in an increase in the prenatal diagnosis of CPAM.\nCPAMs are hamartomatous lesions that are comprised of cystic and adenomatous elements arising from tracheal, bronchial, bronchiolar, or alveolar tissue.\u00a0 These have connections with the tracheobronchial tree. The arterial supply and venous drainage from the lesion are almost always from the pulmonary circulation.\nType 1 is the most common form of CPAM, comprising 60 to 70 percent." +
				" This type is thought to originate from the distal bronchi or proximal bronchioles." +
				" Because there is well-differentiated tissue within the lesions, this type probably originates relatively late during embryogenesis (7 to 10 weeks).\nApproximately three-quarters of patients with a prenatal diagnosis of CPAM are asymptomatic at birth." +
				" When symptomatic, typical signs include tachypnea, increased respiratory effort with grunting and retractions, and cyanosis." +
				" Depending upon the extent of air trapping, large cysts may expand, which leads to respiratory distress." +
				" CXR usually shows a single lesion with one or a few large cysts that may be filled with air or fluid.\nManagement includes close monitoring in utero to management of respiratory distress postnatally." +
				" Complete resection usually recommended because of complications.","Preterm infants are at risk for developing early and late complications that result from anatomic or functional immaturity during the neonatal period. " +
				"The risk of developing complications increases with decreasing gestational age and birth weight."

			};
			testList = new List<string> () {
				"Fetal breathing","Amniotic fluid volume","Fetal tone","Fetal movement","Nonstress test"
			};
			testDescription = new List<string> () {
				"1 or more episodes of rhythmic breathing movements of ≥30 seconds within a 30-min observation period.",
				"A single pocket of fluid is present measuring at least 2 cm by 1 cm.",
				"1 or more episodes of extension/ flexion with return to flexion.",
				"3 or more discrete body or limb movements within 30 min of observation. "
				,"At least 2 episodes of FHR accelerations of at least 15 bpm for at least 15 sec or more."

			};
			tableView = new UITableView()
			{
				Source = new TableViewDataSource(pediometricImageList, colorList,pediometricDiseaseName,pediometricDiseaseDiscription,pediometricLargeImageList,testList,testDescription,this),
			} ;
				
			tableView.AutoresizingMask = UIViewAutoresizing.FlexibleHeight | UIViewAutoresizing.FlexibleWidth;
			tableView.SizeToFit();
			tableView.SeparatorColor = UIColor.Clear;
			tableView.Frame = new CoreGraphics.CGRect (0,0,this.View.Frame.Size.Width ,this.View.Frame.Size.Height-20);
			this.View.AddSubview(tableView);


			var bottomView = new UIImageView ();
			bottomView.Frame = new CoreGraphics.CGRect (0,this.View.Frame.Size.Height-20,this.View.Frame.Size.Width,20);
			bottomView.Image = UIImage.FromBundle ("footer.png");
			bottomView.AutoresizingMask = UIViewAutoresizing.FlexibleWidth;
			this.View.AddSubview (bottomView);

		}
		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
		public void NavigateToOtherView()
		{
			var	descriptionViewController = Storyboard.InstantiateViewController ("PediometricDescriptionViewControllerID") as PediometricDescriptionViewController;
			this.NavigationController.PushViewController (descriptionViewController,true);
	
		}

	}
}

