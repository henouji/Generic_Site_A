import Home from './pages/Home';
import Login from './pages/Login';
import Dashboard from './pages/Dashboard';

export const router = [
  {
    path: "/",
    element: <Home />,
  },
  {
    path: "login",
    element: <Login />,
  },
  {
    path: "dashboard",
    element: <Dashboard />,
  },
];