import React, {Component, useContext} from 'react';
import {Routes, Route, Redirect} from 'react-router-dom'
import {authRoutes, publlcRoutes} from "../routes";
import {SHOP_ROUTE} from "../utils/consts";
import {Context} from "../index";

const AppRouter = () => {
    const isAuth = false
    const {user} = useContext(Context)
    return (
       <Routes>
           {user.isAuth && authRoutes.map(({ path, Component }) =>
               <Route key={path} path={path} element={<Component/>} exact />
           )}

           {publlcRoutes.map(({ path, Component }) =>
               <Route key={path} path={path} element={<Component/>} exact />
           )}
           )}
       </Routes>
    );
};

export default AppRouter;