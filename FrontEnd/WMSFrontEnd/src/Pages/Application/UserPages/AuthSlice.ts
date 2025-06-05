import { createAsyncThunk, createSlice } from '@reduxjs/toolkit'
import { jwtDecode, type JwtPayload } from "jwt-decode";
import  AuthService  from '../../../Services/AuthService'
import type { LoginRequest } from "../Interfaces/Concrete/Auth/LoginRequest";
import type { LoginResponse } from "../Interfaces/Concrete/Auth/LoginResponse";
import type { UserInterface } from '../../../Interfaces/Concrete/Auth/UserInterface';
import type { AppReactMenuItem } from '../../../Interfaces/Concrete/Menus/AppReactMenuItem';




interface MenusState {
  menus: AppReactMenuItem[];
  loading: boolean;
  error: string | null;
}

const initialState: MenusState = {
  menus: [],
  loading: false,
  error: null
};

export const fetchUserMenus = createAsyncThunk<AppReactMenuItem[], number, { rejectValue: string }>(
  'menu/fetchUserMenus',
  async (userId, thunkAPI) => {
    try {
      const response = await AuthService.getUserMenus(userId);
      return response; // AppReactMenuItem[]
    } catch (error: any) {
      return thunkAPI.rejectWithValue(error?.response?.data?.messages || 'Menüler alınamadı');
    }
  }
);


const authSlice = createSlice({
  name: 'menu',
  initialState,
  reducers: {
      clearMenus: (state) => {
      state.menus = [];
      state.loading = false;
      state.error = null;
    }
  },
  extraReducers: (builder) => {
    builder
       .addCase(fetchUserMenus.pending, (state) => {
        state.loading = true;
        state.error = null;
      })
      .addCase(fetchUserMenus.fulfilled, (state, action) => {
        state.menus = action.payload;
        console.log(action.payload)
        state.loading = false;
        state.error = null;
      })
      .addCase(fetchUserMenus.rejected, (state, action) => {
        state.loading = false;
        state.error = action.payload || 'Beklenmeyen bir hata oluştu';
      });
  },
})

export const { clearMenus } = authSlice.actions

export default authSlice.reducer