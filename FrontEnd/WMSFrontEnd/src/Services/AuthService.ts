import type { LoginRequest } from "../Interfaces/Concrete/Auth/LoginRequest";
import type { LoginResponse } from "../Interfaces/Concrete/Auth/LoginResponse";
import queries from "../Api/axioshelper";  


 

const AuthService = {

  login: (credentials: LoginRequest): Promise<LoginResponse> =>
    {
        return queries.post("/Auth/CreateToken", credentials);
    },

   getUserMenus: (userId: number): Promise<AppReactMenuItem[]> => {
    return queries.get(`/Menus/React/${userId}`)
      .then((response) => {
        
        return response.data



      });  
  }
};

export default AuthService;