// using System;

// public class AmbulanceRouteManager : IHospitalNavigation
// {
//     private HospitalUnit _head = null;
//     private HospitalUnit _tail = null;

//     public void AddUnit(string name)
//     {
//         var newUnit = new HospitalUnit(name);
//         if (_head == null)
//         {
//             _head = newUnit;
//             _tail = newUnit;
//             newUnit.Next = _head; // Points to itself to start the circle
//         }
//         else
//         {
//             _tail.Next = newUnit;
//             _tail = newUnit;
//             _tail.Next = _head; // Maintain the circle
//         }
//         Console.WriteLine($"Unit Added: {name}");
//     }

//     public void RemoveUnit(string name)
//     {
//         if (_head == null) return;

//         HospitalUnit current = _head;
//         HospitalUnit previous = _tail;

//         do
//         {
//             if (current.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
//             {
//                 if (current == _head && current == _tail)
//                 {
//                     _head = _tail = null;
//                 }
//                 else
//                 {
//                     previous.Next = current.Next;
//                     if (current == _head) _head = current.Next;
//                     if (current == _tail) _tail = previous;
//                 }
//                 Console.WriteLine($"Maintenance Alert: Unit {name} removed from route.");
//                 return;
//             }
//             previous = current;
//             current = current.Next;
//         } while (current != _head);
//     }

//     public void SetAvailability(string name, bool isAvailable)
//     {
//         var unit = FindUnit(name);
//         if (unit != null) unit.IsAvailable = isAvailable;
//     }

//     public string FindNextAvailable(string startName)
//     {
//         var startNode = FindUnit(startName);
//         if (startNode == null) return "Unknown starting point.";

//         HospitalUnit current = startNode;
//         // Search through the circle once
//         do
//         {
//             if (current.IsAvailable)
//                 return $"Redirecting to available unit: {current.Name}";
            
//             Console.WriteLine($"{current.Name} is full. Moving to next...");
//             current = current.Next;
//         } while (current != startNode);

//         return "Critical: No units available in the entire loop!";
//     }

//     private HospitalUnit FindUnit(string name)
//     {
//         if (_head == null) return null;
//         HospitalUnit temp = _head;
//         do
//         {
//             if (temp.Name.Equals(name, StringComparison.OrdinalIgnoreCase)) return temp;
//             temp = temp.Next;
//         } while (temp != _head);
//         return null;
//     }

//     public void DisplayRoute()
//     {
//         if (_head == null) return;
//         HospitalUnit temp = _head;
//         Console.Write("Current Route: ");
//         do
//         {
//             Console.Write($"{temp.Name} ({(temp.IsAvailable ? "Open" : "Full")}) -> ");
//             temp = temp.Next;
//         } while (temp != _head);
//         Console.WriteLine("[Back to Emergency]");
//     }
// }