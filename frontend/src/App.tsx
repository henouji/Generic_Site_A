import { createBrowserRouter, RouterProvider } from 'react-router-dom';

import Home from './pages/Home';
import Login from './pages/Login';
import Dashboard from './pages/Dashboard';
import DashboardLayout from './layouts/DashboardLayout';

const router = createBrowserRouter([
  {
    element: <DashboardLayout />,
    children: [
      { path: "dashboard", element: <Dashboard /> },
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
