import React, {Component} from 'react';
import {Button, Container, Form, FormControl, Image, Nav, Navbar, NavbarBrand} from "react-bootstrap";
import logo from './nft.png'
import NavbarToggle from "react-bootstrap/NavbarToggle";
import NavbarCollapse from "react-bootstrap/NavbarCollapse";
import {BrowserRouter as Router, Routes, Route, Link} from "react-router-dom";
import Home from "../Pages/Home";
import About from "../Pages/About";
import Catalog from "../Pages/Catalog";
import Sales from "../Pages/Sales";
import info from "../Pages/Info"
import Info from "../Pages/Info";
import Contacts from "../Pages/Contacts";
class Header extends Component {
    render() {
        return (
        <>
            <Navbar sticky={"top"} collapseOnSelect expand={"lg"} bg={"primary"} variant={"dark"}>
                <Container>
                    <Navbar.Brand href={"/"} style={{fontFamily: "Impact"}}>
                        <img
                            src={logo}
                            height={"30"}
                            width={"30"}
                            className={"d-inline-block align-top"}
                            alt={"Logo"}
                        />
                        NFT SHOP
                    </Navbar.Brand>
                    <Navbar.Toggle aria-controls={"responsive-navbar-nav"}/>
                    <Navbar.Collapse id={"responsive-navbar-nav"}>
                        <Nav className={"me-auto"}>
                            <Nav.Link href={"/"} > Главная </Nav.Link>
                            <Nav.Link href={"/catalog"} > Каталог </Nav.Link>
                            <Nav.Link href={"/sales"} > Скидки </Nav.Link>
                            <Nav.Link href={"/about"} > О нас </Nav.Link>
                            <Nav.Link href={"/info"} > Дополнительная информация </Nav.Link>
                            <Nav.Link href={"/contacts"} > Обратная связь </Nav.Link>
                        </Nav>
                        <Form className={"d-inline-flex"}>
                            <FormControl
                            style={{
                                borderRadius: "20px",
                            }}
                            type={"text"}
                            placeholder={"Поиск"}
                            className={"me-sm-2"}
                            />
                            <Button
                                variant={"outline-warning"}
                                style={
                                    {
                                     borderRadius: "20px",
                                    }}
                            >
                            Поиск
                            </Button>
                        </Form>
                    </Navbar.Collapse>
                </Container>
            </Navbar>

            <Router>
            <Routes>
                <Route path='/' element={<Home/>}/>
                <Route path='/catalog' element={<Catalog/>}/>
                <Route path='/sales' element={<Sales/>}/>
                <Route path='/about' element={<About/>}/>
                <Route path='/info' element={<Info/>}/>
                <Route path='/contacts' element={<Contacts/>}/>
            </Routes>
            </Router>
        </>
        );
    }
}

export default Header;