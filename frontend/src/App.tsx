import { createBrowserRouter, RouterProvider } from 'react-router-dom';

import Home from './pages/Home';
import Login from './pages/Login';
import Dashboard from './pages/Dashboard';
import DashboardLayout from './layouts/DashboardLayout';
import Jobs from './pages/Jobs';
import Filler from './pages/Filler';

const router = createBrowserRouter([
  {
    element: <DashboardLayout />,
    children: [
      { path: "dashboard", element: <Dashboard /> },
      { path: "jobs", element: <Jobs /> },
      { path: "lorem", element: <Filler /> },
      { path: "ipsum", element: <Filler /> },
    ]
  },
  { path: "/", element: <Home /> },
  { path: "login", element: <Login /> },
]);

function App() {
  return (
    <RouterProvider router={router} />
  );
}

export default App;
