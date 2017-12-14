using System;
using System.Collections.Generic;
using System.Linq;



namespace Direction_optimized
{
    class TransportationOptimization
    {
        private List<Order> _orders;
        private List<Edge> _map;
        private List<Edge> _new_Map;
        private List<string> _cities;
        private List<Order> optimized_order;
        private List<Edge> optimized_edge;
        private List<string> story;
        private int cost;
        private int[,] matrix;
        private int[,] big_matrix;
        private int[] visited;
        private List<int> travel_order;
        private string[] ordered_city;
        private int capacity=400;
        private bool finish;
        #region Class initial f

        public struct Path
        {
            public int p1, p2, distance;
        }


        public List<Order> Orders
        {
            get
            {
                return _orders;
            }

            set
            {
                _orders = value;
            }
        }

        public List<Edge> Map
        {
            get
            {
                return _map;
            }

            set
            {
                _map = value;
            }
        }

        public List<string> Cities
        {
            get
            {
                return _cities;
            }

            set
            {
                _cities = value;
            }
        }

        public int Capacity
        {
            get
            {
                return capacity;
            }

            set
            {
                capacity = value;
            }
        }

        public bool Finish
        {
            get
            {
                return finish;
            }

            set
            {
                finish = value;
            }
        }

        public List<string> Story
        {
            get
            {
                return story;
            }

            set
            {
                story = value;
            }
        }

        public TransportationOptimization()
        {
            _cities = new List<string>();
            _orders = new List<Order>();
            _map = new List<Edge>();
            _new_Map = new List<Edge>();
            travel_order = new List<int>();
            optimized_order = new List<Order>();
            optimized_edge = new List<Edge>();
            Finish = false;

        }
        #endregion
        private int DecideClusterNumber()
        {
            int result = 1;
            int total = 0;
            
            for(int i=0;i<_orders.Count;i++)
            {
                total += _orders[i].The_number_of_cheese_p;
                total += _orders[i].The_number_of_milk_p;
                total += _orders[i].The_number_of_yogurt_p;
            }
            result = (int)Math.Ceiling((double)((double)total / (double)Capacity));
            

            return result;
        }
        private List<Order>[] Cluster(int x)//number of cluster
        {
            int n = _orders.Count;
            List<Order>[] orderCluster = new List<Order>[x];
            List<Order>[] temporderCluster = new List<Order>[x];
            int[,] dista = new int[_orders.Count, x];
            List<Path> movement = new List<Path>();
            List<Path>[] Path = new List<Path>[n];
            Random rnd = new Random();
            int[] centers = new int[x];
            int[] cl_capacity = new int[x];

            int index;
            int oindex;

            //bool[] ass = new bool[n];

            //random cluster
            int y;
            Order temp_order;
            for (int i = 0; i < x; i++)
            {
                orderCluster[i] = new List<Order>();
                temporderCluster[i] = new List<Order>();
            }
            for (int i=0;i<n;i++)
            {
                temp_order = new Order();
                temp_order = _orders[i];
                y=rnd.Next(0, x);

                orderCluster[y].Add(temp_order);
            }
            bool sat = false;
            bool sat1 = false;
            bool sat2 = false;
            int iteration = -1;
            int max = 0;
            int dist;
            int truck_capacity;
            
            int changeset = -1;
            int temp_dist = 0;
            Order tmp_order2;

                while (!sat1)
                {
                    iteration += 1;
                    for (int i = 0; i < x; i++)
                    {
                        for (int j = 0; j < (orderCluster[i].Count); j++)
                        {
                            index = get_index((orderCluster[i])[j].City);
                            dist = DijkstraAlgoSinglewithTarget(big_matrix, 0, index, _cities.Count);
                            if (dist > max)
                            {
                                max = dist;
                                centers[i] = index;
                            }
                        }
                        max = 0;
                        dist = 0;
                    }

                    for (int i = 0; i < x; i++)
                    {
                        for (int j = 0; j < (orderCluster[i].Count); j++)
                        {
                            oindex = get_oindex((orderCluster[i])[j].City);
                            index = get_index((orderCluster[i])[j].City);
                            dist = DijkstraAlgoSinglewithTarget(big_matrix, index, centers[i], _cities.Count);
                            for (int k = 0; k < centers.Length; k++)
                            {
                                dista[oindex, k] = DijkstraAlgoSinglewithTarget(big_matrix, index, centers[k], _cities.Count);

                            }
                        }
                    }

                    for (int i = 0; i < x; i++)
                        orderCluster[i].Clear();
                    int min;
                    int cl;

                    for (int i = 0; i < dista.Length / x; i++)
                    {
                        min = dista[i, 0];
                        cl = 0;
                        for (int j = 0; j < x; j++)
                        {
                            if (dista[i, j] < min)
                            {
                                min = dista[i, j];
                                cl = j;
                            }
                        }
                        temp_order = new Order();
                        temp_order = _orders[i];
                        orderCluster[cl].Add(temp_order);

                    }
                    if(!(iteration==0))
                    {
                        if (CompareOrderCluster(orderCluster, temporderCluster,x))
                            sat1 = true;
                    }
                    for (int i = 0; i < x; i++)
                    {
                        temporderCluster[i] = new List<Order>();
                        temporderCluster[i] = orderCluster[i];

                    }
                }
                cl_capacity = new int[x];
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < orderCluster[i].Count; j++)
                    {
                        cl_capacity[i] += (orderCluster[i])[j].The_number_of_cheese_p + (orderCluster[i])[j].The_number_of_milk_p + (orderCluster[i])[j].The_number_of_yogurt_p;
                    }
                }
                for(int i = 0; i < x; i++)
                {
                    if(cl_capacity[i]>capacity)
                    {
                        sat1 = false;
                        int ro=findFarElement(orderCluster[i], centers[i]);
                        tmp_order2 = new Order();
                        tmp_order2 = (orderCluster[i])[ro];
                        orderCluster[i].RemoveAt(ro);
                        int new_c;
                        new_c = rnd.Next(0, x);
                        while (!(new_c == i))
                            orderCluster[new_c].Add(tmp_order2);
                        break;
                    }
                if (iteration >= 1000)
                    sat1 = true;

                }
            return orderCluster;
        }

        private int findFarElement(List<Order> c1,int center)
        {
            int result = -1;
            int dist = -1;
            int value;
            for(int i=0;i<c1.Count; i++)
            {
                value = DijkstraAlgoSinglewithTarget(big_matrix, center, get_index(c1[i].City), _cities.Count);
                if (value > dist)
                    result = i;
            }

            return result;
        }

        private bool CompareOrderCluster(List<Order>[] c1, List<Order>[] c2,int x)
        {
            bool result = false;
            for(int i=0;i<x;i++)
            {
                if(c1[i].Count!=c2[i].Count)
                {
                    return false;
                }
                
                for(int j=0;j<c1[i].Count;j++)
                {
                    if ((c1[i])[j].City != (c2[i])[j].City)
                        return false;
                }
                return true;
            }

            return result;
        }

        private void FillMatrix()
        {
            big_matrix = new int[_cities.Count, _cities.Count];
            for (int i = 0; i < _cities.Count; i++) //Full graph for dj shortest path
                for (int j = 0; j < _cities.Count; j++)
                {
                    if (i == j)
                    {
                        big_matrix[i, j] = 0;
                    }
                    else
                    {
                        big_matrix[j, i] = big_matrix[i, j] = MapSearch(Map, _cities[i], _cities[j]);
                    }
                }

        }
        public List<string> GetStory()
        {
            return Story;
        }
        private int FindOrderbyName(string c)
        {
            int result = -1;
            for (int i=0;i<_orders.Count;i++)
            {
                if(_orders[i].City==c)
                {
                    return i;
                }
            }
            return result;
        }
        public void Optimization()
        {
            FillMatrix();
            int numberofCluster = DecideClusterNumber();
            List<Order>[] OrderCluster = Cluster(numberofCluster);
            Story = new List<string>();
            for (int c = 0; c < OrderCluster.Length; c++)
            {
                _orders = OrderCluster[c];
                CreateEliminatedMap();

                FullFillArray();
                travel_order = new List<int>();
                Minimize(0);//TSP , fills the travel_order
                List<Path> path;
                int yt;
                Story.Add((c + 1).ToString()+". Transportation");
                for (int i = 0; i < travel_order.Count - 1; i++)
                {
                    string s1 = "Go from City " + Cities[convert_index(travel_order[i] - 1)] + " to City " + Cities[convert_index(travel_order[i + 1] - 1)];
                    Story.Add(s1);
                    path = DijkstraAlgo(big_matrix, convert_index(travel_order[i] - 1), convert_index(travel_order[i + 1] - 1), _cities.Count);
                    for (int j = path.Count - 1; j >= 0; j--)
                    {
                        string s2 = "   Use Path from " + Cities[path[j].p1] + "to City " + Cities[path[j].p2];
                        Story.Add(s2);
                    }
                    yt = FindOrderbyName(Cities[convert_index(travel_order[i + 1] - 1)]);
                    if (yt != -1)
                    {
                        string s3 = "#####Leave the Pool Point Order; Cheese:" + _orders[yt].The_number_of_cheese_p.ToString() + "Yogurt: " + _orders[yt].The_number_of_yogurt_p.ToString() + " Milk: " + _orders[yt].The_number_of_milk_p.ToString();
                        Story.Add(s3);
                    }

                }
            }



            finish = true;



            int y = 0;
            //KruskalAlgoritm();

        }

        private int get_index(string c)
        {
            int result = 0;
            for(int i=0;i<_cities.Count;i++)
            {
                if (_cities[i] == c)
                    return i;
            }

            return result;
        }
        private int get_oindex(string c)
        {
            int result = 0;
            for (int i = 0; i < _orders.Count; i++)
            {
                if (_orders[i].City == c)
                    return i;
            }

            return result;
        }
        private int convert_index(int x)
        {
            int result = -1;
            for (int i = 0; i < _cities.Count; i++)
            {
                if(ordered_city[x]==_cities[i])
                {
                    result = i;
                }   
            }

            return result;
        }

        private void FullFillArray()
        {
            int n = _orders.Count+1;
            int x;
            matrix = new int[n, n];
            
            visited = new int[n];

            for (int i = 0; i < n; i++)
                visited[i] = 0;

            ordered_city = new string[Orders.Count+1];
            ordered_city[0] = "A";
            for (int i = 1; i < ordered_city.Length; i++)
                ordered_city[i] = Orders[i-1].City;
            
            for(int i=0;i<ordered_city.Length;i++)
                for(int j = 0; j < ordered_city.Length; j++)
                {
                    if(i==j)
                    {
                        matrix[i, j] = 0;
                    }
                    else
                    {
                       
                        matrix[j,i]= matrix[i, j] = MapSearch(_new_Map,ordered_city[i],ordered_city[j]);
                    }
                }

            

        }

        List<Order> GetOptimizedOrder()
        {
            return optimized_order;

        }
        List<Edge> GetOptimizedRoute()
        {
            return optimized_edge;

        }


        private void CreateEliminatedMap()
        {
            List<string> not_ordered_city = new List<string>();

            bool ordered = false;

            //Siparis verilmemis sehirleri buluyoruz
            for (int i = 1; i < _cities.Count; i++) // ilk sehir A ve merkez. A olanlari silmemesi icin 1 den basliyor.
            {
                for (int j = 0; j < _orders.Count; j++)
                {
                    if (_cities[i] == _orders[j].City)
                    {
                        ordered = true;
                    }
                }
                if (!ordered)
                {
                    not_ordered_city.Add(_cities[i]);
                }
                ordered = false;
            }

            for(int i=0;i<_map.Count;i++)
            {
                _new_Map.Add(new Edge(_map[i]));
            }


            List<Edge> removed_edges = new List<Edge>();
            List<Edge> new_edges = new List<Edge>();

            MapDesign(_new_Map, not_ordered_city, removed_edges);

            Edge temp;
            string p1 = "";
            string p2 = "";




            for (int k = 0; k < not_ordered_city.Count; k++)
            {
                MapDesign(_new_Map, removed_edges, not_ordered_city[k]);
                for (int i = 0; i < removed_edges.Count; i++)
                {
                    for (int j = i + 1; j < removed_edges.Count; j++)
                    {
                        if (removed_edges[i].p1_name == not_ordered_city[k])
                        {
                            p1 = removed_edges[i].p2_name;
                        }
                        else if (removed_edges[i].p2_name == not_ordered_city[k])
                        {
                            p1 = removed_edges[i].p1_name;

                        }

                        if (removed_edges[j].p1_name == not_ordered_city[k])
                        {
                            p2 = removed_edges[j].p2_name;
                        }
                        else if (removed_edges[j].p2_name == not_ordered_city[k])
                        {
                            p2 = removed_edges[j].p1_name;
                        }
                        //if (removed_edges[j].p2_name != not_ordered_city[k] && removed_edges[j].p1_name != not_ordered_city[k])
                        //   {
                        //   map.Add(removed_edges[i]);
                        //   }
                        if (p1 != "" && p2 != "")
                        {
                            temp = new Edge();
                            temp.p1_name = p1;
                            temp.p2_name = p2;
                            temp.distance = removed_edges[i].distance + removed_edges[j].distance;
                            if (!MapSearch(_new_Map, temp))
                                _new_Map.Add(temp);


                            //for (int m = 0; m < removed_edges.Count; m++)
                            //    map.Add(removed_edges[m]);
                            //removed_edges.Clear();
                        }
                        p1 = "";
                        p2 = "";
                    }
                }




                //removed_edges.Clear();
                //MapDesign(map, not_ordered_city, removed_edges);
            }


            //MessageBox.Show("Merhaba");





        }
        private bool MapSearch(List<Edge> map2, Edge temp)
        {
            bool result = false;

            for (int i = 0; i < map2.Count; i++)
            {
                if ((map2[i].p1_name == temp.p1_name && map2[i].p2_name == temp.p2_name) || (map2[i].p1_name == temp.p2_name && map2[i].p2_name == temp.p1_name))
                {
                    if (map2[i].distance < temp.distance)
                    {
                        return true;
                    }
                    else
                    {
                        map2[i].distance = temp.distance;

                        return true;
                    }
                }
            }

            return result;
        }

        private int MapSearch(List<Edge> map2, string p1,string p2)
        {
            Edge temp = new Edge();
            temp.p1_name = p1;
            temp.p2_name = p2;
            int result = 0;

            for (int i = 0; i < map2.Count; i++)
            {
                if ((map2[i].p1_name == temp.p1_name && map2[i].p2_name == temp.p2_name) || (map2[i].p1_name == temp.p2_name && map2[i].p2_name == temp.p1_name))
                {
                    return (int) map2[i].distance;
                }
            }

            return result;
        }

        private void MapDesign(List<Edge> map2, List<Edge> removed_edge2, string deleted_city)
        {

            removed_edge2.Clear();
            for (int j = 0; j < map2.Count; j++)
            {
                if (map2[j].p1_name == deleted_city || map2[j].p2_name == deleted_city)
                {
                    removed_edge2.Add(_new_Map[j]);
                    map2.RemoveAt(j);
                    j--;
                }
            }

        }
        private void MapDesign(List<Edge> map2, List<string> not_ordered_city2, List<Edge> removed_edge2)
        {
            removed_edge2.Clear();
            for (int i = 0; i < not_ordered_city2.Count; i++)
            {
                for (int j = 0; j < map2.Count; j++)
                {
                    if (not_ordered_city2[i] == _new_Map[j].p1_name || not_ordered_city2[i] == map2[j].p2_name)
                    {
                        removed_edge2.Add(_new_Map[j]);
                        //map2.RemoveAt(j);
                        //j--;
                    }
                }
            }
        }
        private List<Edge> KruskalAlgoritm()
        {
            List<Edge> result = new List<Edge>();
            Edge sample = new Edge();
            List<Edge> Sortedmap = _new_Map.OrderBy(o => o.distance).ToList();
            List<Edge> SelectedEdge = new List<Edge>();
            List<string> InsertedCity = new List<string>();
            double distance = 0;

            for (int i = 0; i < Sortedmap.Count; i++)
            {
                if (InsertedCity.IndexOf(Sortedmap[i].p1_name) < 0 || InsertedCity.IndexOf(Sortedmap[i].p2_name) < 0)
                {

                    SelectedEdge.Add(Sortedmap[i]);
                    if (InsertedCity.IndexOf(Sortedmap[i].p1_name) < 0)
                        InsertedCity.Add(Sortedmap[i].p1_name);
                    if (InsertedCity.IndexOf(Sortedmap[i].p2_name) < 0)
                        InsertedCity.Add(Sortedmap[i].p2_name);
                    distance += Sortedmap[i].distance;

                }
                if (InsertedCity.Count == _cities.Count)
                    break;

            }

            for (int i = 0; i < SelectedEdge.Count; i++)
            {
                result.Add(SelectedEdge[i]);
            }

            return result;

        }
        private int travel_least(int c)
        {
            
            int i, nc = 999;
            int min = 999;
            int kmin = 0;
            int n = _orders.Count + 1;
            for(i=0;i<n;i++)
            {
                if((matrix[c,i]!=0 )&&(visited[i]==0))
                    if(matrix[c,i]+matrix[i,c]<min)
                    {
                        min = matrix[i, 0] + matrix[c,i];
                        kmin = matrix[c, i];
                        nc = i;

                    }
            }

            if (min != 999)
                cost += kmin;
            if(nc==999)
            {
                
            }
            return nc;
        }

        private void Minimize(int city)
        {
            
            int c = new int();
            c = city;
            int i, ncity;
            visited[city] = 1;
            travel_order.Add(c+1);
            ncity = travel_least(city);
            
            if(ncity==999)
            {
                ncity = 0;
                travel_order.Add(ncity+1);
                cost += matrix[city, ncity];
                return;
            }
            Minimize(ncity);

        }

        private static int MinimumDistance(int[] distance, bool[] shortestPathTreeSet, int verticesCount)
        {
            int min = int.MaxValue;
            int minIndex = 0;

            for (int v = 0; v < verticesCount; ++v)
            {
                if (shortestPathTreeSet[v] == false && distance[v] <= min)
                {
                    min = distance[v];
                    minIndex = v;
                }
            }

            return minIndex;
        }

        

        public static List<Path>  DijkstraAlgo(int[,] graph, int source,int target, int verticesCount)
        {
            int[] distance = new int[verticesCount];
            bool[] shortestPathTreeSet = new bool[verticesCount];
            List<Path> shortestpath = new List<Path>();
            List<Path> somepaths = new List<Path>();
            Path p;

            for (int i = 0; i < verticesCount; ++i)
            {
                distance[i] = int.MaxValue;
                shortestPathTreeSet[i] = false;
            }

            distance[source] = 0;

            for (int count = 0; count < verticesCount - 1; ++count)
            {
                int u = MinimumDistance(distance, shortestPathTreeSet, verticesCount);
                shortestPathTreeSet[u] = true;

                for (int v = 0; v < verticesCount; ++v)
                    if (!shortestPathTreeSet[v] && Convert.ToBoolean(graph[u, v]) && distance[u] != int.MaxValue && distance[u] + graph[u, v] < distance[v])
                    {
                        
                        distance[v] = distance[u] + graph[u, v];
                        p = new Path(); p.p1 = u;p.p2 = v;p.distance = graph[u, v]; somepaths.Add(p);
                        if (v == target)
                        {
                            count = verticesCount;
                            break;
                            
                        }

                    }
            }
            bool find = false;
            int k = somepaths.Count;
            int path_target = target;
            //shortestpath.Add(somepaths[k - 1]);
            int t = k - 1;
            while(!find)
            {
                for (int i = t; i >= 0; i--)
                {
                    if (somepaths[i].p2 == path_target)
                    {
                        shortestpath.Add(somepaths[i]);
                        path_target = somepaths[i].p1;
                    }
                    if (path_target == source)
                    {
                        find = true;
                        break;
                    }
                    
                   } 
            }



            return shortestpath;

            
        }
        public static int[] DijkstraAlgoSingle(int[,] graph, int source, int verticesCount)
        {
            int[] distance = new int[verticesCount];
            bool[] shortestPathTreeSet = new bool[verticesCount];
            
            
            Path p;

            for (int i = 0; i < verticesCount; ++i)
            {
                distance[i] = int.MaxValue;
                shortestPathTreeSet[i] = false;
            }

            distance[source] = 0;

            for (int count = 0; count < verticesCount - 1; ++count)
            {
                int u = MinimumDistance(distance, shortestPathTreeSet, verticesCount);
                shortestPathTreeSet[u] = true;

                for (int v = 0; v < verticesCount; ++v)
                    if (!shortestPathTreeSet[v] && Convert.ToBoolean(graph[u, v]) && distance[u] != int.MaxValue && distance[u] + graph[u, v] < distance[v])
                    {

                        distance[v] = distance[u] + graph[u, v];
                       

                    }
            }
            return distance;
           

        }
        public static int DijkstraAlgoSinglewithTarget(int[,] graph, int source,int target, int verticesCount)
        {
            int[] distance = new int[verticesCount];
            bool[] shortestPathTreeSet = new bool[verticesCount];


            Path p;

            for (int i = 0; i < verticesCount; ++i)
            {
                distance[i] = int.MaxValue;
                shortestPathTreeSet[i] = false;
            }

            distance[source] = 0;

            for (int count = 0; count < verticesCount - 1; ++count)
            {
                int u = MinimumDistance(distance, shortestPathTreeSet, verticesCount);
                shortestPathTreeSet[u] = true;

                for (int v = 0; v < verticesCount; ++v)
                    if (!shortestPathTreeSet[v] && Convert.ToBoolean(graph[u, v]) && distance[u] != int.MaxValue && distance[u] + graph[u, v] < distance[v])
                    {

                        distance[v] = distance[u] + graph[u, v];


                    }
            }

            return distance[target];


        }

    }
}
