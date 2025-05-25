import { createBrowserRouter } from "react-router";

// Areas
import LandingArea from "../Areas/Landing/LandingArea";
import ApplicationArea from "../Areas/Application/ApplicationArea";

// pages 
import LandingHomePage from "../Pages/Landing/LandingHomePage";
import HistoryPage from "../Pages/Landing/HistoryPage";
import LoginPage from "../Pages/Application/LoginPage/LoginPage";
import RequireAuth from "./RequireAuth";
import DashboardPage from "../Pages/Application/Dashboard/DashboardPage";
import UserPages from "../Pages/Application/UserPages/UserPages";


// Shared
import ErrorPage from  "../Pages/Shared/ErrorPage";
import NotFoundPage from "../Pages/Shared/NotFoundPage";

export const router = createBrowserRouter([
  {
    path:"/error",
    element: <ErrorPage/>
  },
    {
    path:"*",
    element: <NotFoundPage/>
  },
  
  {
    path: "/",
    element: <LandingArea/>,
    children: [
      {
        path: "",
        element: <LandingHomePage />
      },
      {
        path: "/history",
        element: <HistoryPage />
      },
      {
        path: "/login",
        element: <LoginPage />
      },
    ]
  },
  {
    // 👇 Auth gerektiren alan
    element: <RequireAuth />, // koruma katmanı
    children: [
      {
        path: "/admin",
        element: <ApplicationArea />, // layout
        children: [
          {
            path: "dashboard", // yani /dashboard
            element: <DashboardPage />,
          },
             {
            path: "users", // yani /dashboard
            element: <UserPages />,
          },
        ],
      },
    ],
  },
]);
