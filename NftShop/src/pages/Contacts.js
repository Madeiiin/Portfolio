import React, {Component} from 'react';
import {Container, Form, Button, FormCheck} from "react-bootstrap";

class Contacts extends Component {
    render() {
        return (

            <Container className={"Contacts"} style={{width:"500px"}}>
                <h1> Связаться с нами. </h1>
                <Form>
                    <Form.Group controlId={"formBasicEmail"}>
                        <Form.Label> Адрес электронной почты: </Form.Label>
                        <Form.Control type="email" placeholder="Введите адрес эл. почты" style={{border: "solid #056efd 1px"}}/>
                        <Form.Text style={{color: "black"}}>
                            Мы обязательно ответим! (нет)
                        </Form.Text>
                    </Form.Group>

                    <Form.Group controlId={"formBasicPassword"}>
                        <Form.Label> Опишите проблему: </Form.Label>
                        <Form.Control as={"textarea"} rows={"3"} style={{border: "solid #056efd 1px"}}/>
                    </Form.Group>

                    <Form.Group controlId={"formBasicCheckBox"}>
                        <Form.Check type={"checkbox"} label={"Поддерживаю Путина"}/>
                    </Form.Group>

                    <Button variant={"outline-primary"} style={
                        {
                            borderRadius: "20px", marginBottom: "10px",
                        }} type={"submit"}>Отправить</Button>
                </Form>
            </Container>

        );
    }
}

export default Contacts;