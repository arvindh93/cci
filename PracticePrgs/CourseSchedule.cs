/**
There are a total of numCourses courses you have to take, labeled from 0 to numCourses - 1. You are given an array prerequisites where prerequisites[i] = [ai, bi] indicates that you must take course bi first if you want to take course ai.

For example, the pair [0, 1], indicates that to take course 0 you have to first take course 1.
Return true if you can finish all courses. Otherwise, return false.

 

Example 1:

Input: numCourses = 2, prerequisites = [[1,0]]
Output: true
Explanation: There are a total of 2 courses to take. 
To take course 1 you should have finished course 0. So it is possible.
Example 2:

Input: numCourses = 2, prerequisites = [[1,0],[0,1]]
Output: false
Explanation: There are a total of 2 courses to take. 
To take course 1 you should have finished course 0, and to take course 0 you should also have finished course 1. So it is impossible.

**/

namespace PracticePrgs;

public class CourseSchedule
{
    
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        Graph g = new Graph();

        foreach (var preq in prerequisites)
        {
            g.AddEdge(preq[0], preq[1]);
        }
        
        //check for circ dependency
        return !g.HasCycle();
    }
}
public class Graph
{
    private Dictionary<int, List<int>> graph = [];
    public void AddVertex(int v)
    {
        if (graph.ContainsKey(v))
        {
            return;
        }

        graph[v] = [];
    }

    public void AddEdge(int from, int to)
    {
        AddVertex(from);
        AddVertex(to);
        if (!graph[from].Contains(to))
        {
            graph[from].Add(to);
        }
    }

    public bool HasCycle()
    {
        HashSet<int> visited = [];
        HashSet<int> recStack = [];
        foreach(var (vertex, edges) in graph)
        {
            if (DFS(vertex, visited, recStack))
            {
                return true;
            }
        }

        return false;
    }

    private bool DFS(int node, HashSet<int> visited, HashSet<int> recStack)
    {
        if (recStack.Contains(node))
        {
            return true;
        }

        if (visited.Contains(node))
        {
            return false;
        }

        recStack.Add(node);
        visited.Add(node);

        if (graph.ContainsKey(node))
        {
            foreach (var neighbor in graph[node])
            {
                if (DFS(neighbor, visited, recStack))
                {
                    return true;
                }
            }
        }

        recStack.Remove(node);
        return false;
    }
}