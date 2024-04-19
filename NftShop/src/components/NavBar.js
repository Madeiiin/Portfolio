import React, {useContext} from 'react';
import {Context} from "../index";
import {Button, Container, Nav, Navbar} from "react-bootstrap";
import {Link, NavLink, useNavigate} from "react-router-dom";
import {
    ABOUT_ROUTE,
    ADMIN_ROUTE, ADVERT_ROUTE,
    AUTH_ROUTE,
    CONTACTS_ROUTE,
    INFO_ROUTE, PROFILE_ROUTE,
    SALES_ROUTE,
    SHOP_ROUTE
} from "../utils/consts";
import {observer} from "mobx-react-lite";

const NavBar = observer(() => {
    const {user} = useContext(Context)
    const navigate = useNavigate()

    return (
        <Navbar bg="primary" variant="dark">
            <Container>
                <NavLink style={{color:'white'}} to={SHOP_ROUTE}>NFT SHOP</NavLink>
                <NavLink style={{color:'white'}} to={ABOUT_ROUTE}>About us</NavLink>
                <NavLink style={{color:'white'}} to={CONTACTS_ROUTE}>Contacts</NavLink>
                <NavLink style={{color:'white'}} to={SALES_ROUTE}>Sales</NavLink>
                <NavLink style={{color:'white'}} to={INFO_ROUTE}>Info</NavLink>
                <Link to="/Advert"><h1 className="advert">Реклама</h1></Link>

                    {user.isAuth ?
                    <Nav className="ml-auto">
                        <Button
                            variant={"outline-light"}
                            onClick={() => navigate(PROFILE_ROUTE)}
                            className='me-2'
                        >
                            Profile
                        </Button>
                        <Button
                            variant={"outline-light"}
                            onClick={() => navigate(SHOP_ROUTE) }
                        >Disconnect
                        </Button>
                    </Nav>
                    :
                    <Nav className="ml-auto">
                        <Button
                            variant={"outline-light"}
                            onClick={() => navigate(AUTH_ROUTE)}
                        >Login
                        </Button>

                    </Nav>


                }
            </Container>
        </Navbar>
    );
});

export default NavBar;