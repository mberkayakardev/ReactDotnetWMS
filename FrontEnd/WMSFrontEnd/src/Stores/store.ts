import { combineReducers, configureStore } from '@reduxjs/toolkit'
import { useDispatch, useSelector } from 'react-redux';
import authReducer from '../Pages/Application/LoginPage/AuthSlice';
import { persistReducer, persistStore } from 'redux-persist';
import menuReducer from '../Pages/Application/UserPages/AuthSlice';

import storage from 'redux-persist/lib/storage'; // localStorage

/// f5 te state ler gitmesin
const rootReducer = combineReducers({
  auth: authReducer,
  menu: menuReducer
});

const authPersistConfig = {
  key: 'auth',
  storage,
   whitelist: ['auth', 'menu'] 
};


const persistedReducer = persistReducer(authPersistConfig, rootReducer);
/// f5 te state ler gitmesin


// export const store = configureStore({
//   reducer: {
//     /// f5 te state kaybetmemek için 
//     // auth: authReducer,
//     auth: persistReducer(authPersistConfig, authReducer), // sadece bu persist edilecek

//   },
// })

export const store = configureStore({
  reducer: persistedReducer,
  middleware: (getDefaultMiddleware) =>
    getDefaultMiddleware({
      serializableCheck: false, // redux-persist uyumu
    }),
});


//// sayfa yenilendiğinde state ler kaybolmasın diye
export const persistor = persistStore(store);


export type RootState = ReturnType<typeof store.getState>
export type AppDispatch = typeof store.dispatch

/// Type Güvenli kendi costume hook larım 

export const UseAppDispatch = useDispatch.withTypes<AppDispatch>();
export const UseAppSelector = useSelector.withTypes<RootState>();
