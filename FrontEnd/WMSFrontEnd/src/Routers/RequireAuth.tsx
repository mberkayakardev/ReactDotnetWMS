import { Navigate, Outlet } from "react-router";
import { UseAppSelector } from "../Stores/store";
import { toast } from "react-toastify";

export default function RequireAuth() {
  const user = UseAppSelector((state) => state.auth.user);

  if (!user) {
    toast.error("Lütfen giriş yapınız ")
    return <Navigate to="/login" replace />;
  }

  return <Outlet />;
}
