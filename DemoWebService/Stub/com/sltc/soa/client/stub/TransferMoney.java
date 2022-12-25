
package com.sltc.soa.client.stub;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for anonymous complex type.
 * 
 * <p>The following schema fragment specifies the expected content contained within this class.
 * 
 * <pre>
 * &lt;complexType>
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="accout_balance" type="{http://www.w3.org/2001/XMLSchema}double"/>
 *         &lt;element name="transfer_money" type="{http://www.w3.org/2001/XMLSchema}double"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "", propOrder = {
    "accoutBalance",
    "transferMoney"
})
@XmlRootElement(name = "TransferMoney")
public class TransferMoney {

    @XmlElement(name = "accout_balance")
    protected double accoutBalance;
    @XmlElement(name = "transfer_money")
    protected double transferMoney;

    /**
     * Gets the value of the accoutBalance property.
     * 
     */
    public double getAccoutBalance() {
        return accoutBalance;
    }

    /**
     * Sets the value of the accoutBalance property.
     * 
     */
    public void setAccoutBalance(double value) {
        this.accoutBalance = value;
    }

    /**
     * Gets the value of the transferMoney property.
     * 
     */
    public double getTransferMoney() {
        return transferMoney;
    }

    /**
     * Sets the value of the transferMoney property.
     * 
     */
    public void setTransferMoney(double value) {
        this.transferMoney = value;
    }

}
