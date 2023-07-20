
using DemoGeneriqueTourneVis.Classes;

Queue<Vis> visAVisser = new Queue<Vis>();

visAVisser.Enqueue(new VisCruciforme());
visAVisser.Enqueue(new VisCruciforme());
visAVisser.Enqueue(new VisPlate());
visAVisser.Enqueue(new VisPlate());
visAVisser.Enqueue(new VisCruciforme());
visAVisser.Enqueue(new VisPlate());
visAVisser.Enqueue(new VisCruciforme());

TourneVis<VisCruciforme> tourneVisCruciforme = new TourneVis<VisCruciforme>();
TourneVis<VisPlate> touneVisPlat = new TourneVis<VisPlate>();
Vis laVis = visAVisser.Dequeue();
if (laVis is VisCruciforme visCruciforme)
tourneVisCruciforme.Visser(visCruciforme);

TourneVisAEmbouts tourneVisAEmbouts = new TourneVisAEmbouts();

laVis = visAVisser.Dequeue();

tourneVisAEmbouts.Visser(laVis);
laVis = visAVisser.Dequeue();

tourneVisAEmbouts.Visser(laVis);